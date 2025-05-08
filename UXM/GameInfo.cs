using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace UXM
{
#if DEBUG
    public class GameInfo
#else
    class GameInfo
#endif
    {
        public long RequiredGB;
        public BHD5.Game BHD5Game;
        public List<string> Archives;
        public ArchiveDictionary Dictionary;
        public List<string> BackupDirs;
        public List<string> DeleteDirs;
        public List<string> Replacements;
        public List<string> Replace;
        public static readonly string ExeDir = AppDomain.CurrentDomain.BaseDirectory;

        public GameInfo(string xmlStr, string dictionaryStr, Util.Game game)
        {
            XDocument xml = XDocument.Parse(xmlStr);
            RequiredGB = long.Parse(xml.Root.Element("required_gb").Value);
            BHD5Game = (BHD5.Game)Enum.Parse(typeof(BHD5.Game), xml.Root.Element("bhd5_game").Value);
            Archives = xml.Root.Element("archives").Elements().Select(element => element.Value).ToList();
            BackupDirs = xml.Root.Element("backup_dirs").Elements().Select(element => element.Value).ToList();
            DeleteDirs = xml.Root.Element("delete_dirs").Elements().Select(element => element.Value).ToList();
            Replacements = xml.Root.Element("replacements").Elements().Select(element => element.Value).ToList();
            Dictionary = new ArchiveDictionary(dictionaryStr, BHD5Game);
            if (game == Util.Game.DarkSouls)
            {
                Replace = xml.Root.Element("replace").Elements().Select(element => element.Value).ToList();
            }
        }

        public static GameInfo GetGameInfo(Util.Game game)
        {

            string prefix = GetPrefix(game);
            string gameInfo = File.ReadAllText($@"{ExeDir}/res/{prefix}GameInfo.xml");
            string dictionary = File.ReadAllText($@"{ExeDir}/res/{prefix}Dictionary.txt");

            return new GameInfo(gameInfo, dictionary, game);
        }

        public static string GetPrefix(Util.Game game)
        {
            string prefix;
            switch (game)
            {
                case Util.Game.DarkSouls:
                    prefix = "DarkSouls";
                    break;
                case Util.Game.DarkSouls2:
                    prefix = "DarkSouls2";
                    break;
                case Util.Game.Scholar:
                    prefix = "Scholar";
                    break;
                case Util.Game.DarkSouls3:
                    prefix = "DarkSouls3";
                    break;
                case Util.Game.Sekiro:
                    prefix = "Sekiro";
                    break;
                case Util.Game.SekiroBonus:
                    prefix = "SekiroBonus";
                    break;
                case Util.Game.EldenRing:
                    prefix = "EldenRing";
                    break;
                case Util.Game.ArmoredCore6:
                    prefix = "ArmoredCore6";
                    break;
                default:
                    throw new ArgumentException("Invalid game type.");
            }
            return prefix;
        }
    }
}
