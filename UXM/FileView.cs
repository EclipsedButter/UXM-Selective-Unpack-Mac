using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Eto.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
using System.Linq;

namespace UXM
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class FileView : Form, INotifyPropertyChanged
    {
        public string Prefix;
        public ObservableCollection<TreeNode> TreeNodesCollection { get; set; }

        private string _filterItems = "";
        public string ItemFilter
        {
            get => _filterItems;
            set
            {
                SetField(ref _filterItems, value);
                FilterTreeView();
            }
        }
        private bool _expand = false;
        public bool Expand
        {
            get => _expand;
            set => SetField(ref _expand, value);
        }

        public FileView()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            TreeGridItemCollection foo = new();
            foo.AddRange(TreeNodesCollection);
            fileTree.DataStore = foo; //! who needs data binding
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            fileTree.ReloadData();
        }
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        private Util.Game? _currentGame { get; set; } = null;
        public void PopulateTreeview(string exePath)
        {
            Util.Game game;

            if (File.Exists(exePath))
                game = Util.GetExeVersion(exePath);
            else
                return;


            if (_currentGame != null && _currentGame == game)
                return;

            _currentGame = game;

            Prefix = GameInfo.GetPrefix(game);

            var fileList = File.ReadAllLines($@"{GameInfo.ExeDir}res/{Prefix}Dictionary.txt").Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            Application.Instance.Invoke(() =>
            {
                TreeNodesCollection = new ObservableCollection<TreeNode>(new List<TreeNode> { PopulateTreeNodes(fileList, @"/", Prefix) });
            });

            OnPropertyChanged(nameof(TreeNodesCollection));
        }
        private TreeNode PopulateTreeNodes(string[] paths, string pathSeparator, string prefix)
        {
            if (paths == null)
                return null;

            TreeNode thisnode = new TreeNode(null, prefix, false) { Root = fileTree };
            TreeNode currentnode;
            char[] cachedpathseparator = pathSeparator.ToCharArray();
            bool sound = false;

            foreach (string path in paths)
            {
                sound = path == "#sd";

                if (path.StartsWith("#"))
                    continue;

                string newPath = path;
                if (sound)
                    newPath = $"/sd/{path}";

                currentnode = thisnode;
                foreach (string subPath in newPath.Split(cachedpathseparator, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (currentnode[subPath] == null)
                        currentnode.Nodes.Add(new TreeNode(currentnode, subPath, sound) { Root = fileTree });

                    currentnode = currentnode[subPath];
                }
            }

            return thisnode;
        }

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void TreeViewItem_Collapsed(object sender, RoutedEventArgs e)
        //{
        //    (sender as TreeViewItem).IsExpanded = true;
        //}

        public void FilterTreeView()
        {
            foreach (TreeNode n in TreeNodesCollection.Traverse())
            {
                n.Expanded = n.Name.ToLower().Contains(ItemFilter.ToLower()) || n.HasChildWithName(ItemFilter.ToLower());
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            (Parent as FormFileView).SaveSelection();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            TreeNodesCollection[0].Selected = true;
            fileTree.ReloadData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TreeNodesCollection[0].Selected = true;
            TreeNodesCollection[0].Selected = false;
            if (ItemFilter != "")
                ItemFilter = "";
            fileTree.ReloadData();
        }

        //private void Show_Click(object sender, RoutedEventArgs e)
        //{
        //    List<string> list = new List<string>();

        //    void Get(TreeNode nodes)
        //    {
        //        foreach (var node in nodes.Nodes)
        //        {
        //            if (node.Nodes.Count > 0)
        //                Get(node);
        //            else
        //                if (node.Selected) list.Add(node.FullPath);

        //        }
        //    }

        //    Get(TreeNodesCollection[0]);
        //    MessageBox.Show(list[0]);
        //}

        FormFileView Parent { get; set; }
#if DEBUG
        public void SetParent(FormFileView formFileView)
#else
        internal void SetParent(FormFileView formFileView)
#endif
        {
            Parent = formFileView;
        }
    }
}
