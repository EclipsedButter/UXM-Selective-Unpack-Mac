using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Data;
using Eto.Forms;
using Eto.Drawing;
using SoulsFormats;
using System.Drawing;

namespace UXM
{
    public class TreeNode : INotifyPropertyChanged, ITreeGridItem<TreeNode>
    {
        public ObservableCollection<TreeNode> Nodes { get; set; }
        public ObservableCollection<TreeNode> Children => Nodes;
        public static TreeNode TopClick = null;
        public string Name { get; set; }
        public TreeGridView Root = null;
        public ITreeGridItem Parent { get; set;  }
        public string FullPath => $"{(Parent as TreeNode)?.FullPath}/{Name}";
        public bool IsSound { get; set; }

        public Image Image => null;
        public string Text {
            get {
                return Name;
            }
            set {
                Name = value;
            }
        }
        public string Key => Name;
        public int Count => Nodes.ToArray().Length;
        public TreeNode this[int i] => Nodes[i];
        public bool Expandable => Count > 0;

        private bool _visibility = true;
        public bool Visibility
        {
            get => _visibility;
            set => SetField(ref _visibility, value);
        }

        private bool _expanded = false;
        public bool Expanded
        {
            get => _expanded;
            set => SetField(ref _expanded, value);
        }

        private bool _selected;
        public bool Selected
        {
            get => _selected;
            set
            {
                if (SetField(ref _selected, value))
                {
                    if (TopClick is null)
                        TopClick = this;

                    if (!_correcting)
                    {
                        foreach (TreeNode node in Nodes)
                        {
                            node.Selected = Selected;
                        }
                    }
                   
                    if (Parent != null && !Selected)
                        (Parent as TreeNode).CorrectCheckbox();

                    if (TopClick == this)
                    {
                        Root.ReloadData();
                        TopClick = null;
                    }
                }
            }
        }

        private bool _correcting;
        private void CorrectCheckbox()
        {
            _correcting = true;
            Selected = false;
            _correcting = false;
        }

        public TreeNode(TreeNode parent, string name, bool isSound)
        {
            Parent = parent;
            Name = name;
            Nodes = new ObservableCollection<TreeNode>();
            IsSound = isSound;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName ?? "");
            return true;
        }

        public TreeNode this[string s]
        {
            get
            {
                foreach (TreeNode node in Nodes)
                {
                    if (node.Name == s)
                        return node;
                }

                return null;
            }
        }

        public bool HasChildWithName(string itemFilter)
        {
            foreach (TreeNode node in Nodes)
            {
                if (node.Name.ToLower().Contains(itemFilter) || node.HasChildWithName(itemFilter))
                    return true;
            }
            return false;
        }

        public bool HasUnselectedChildren()
        {
            foreach (TreeNode node in Nodes)
            {
                return node.Selected && node.HasUnselectedChildren();
            }
            return false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
