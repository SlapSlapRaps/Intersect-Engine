using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DarkUI.Forms;

using Intersect.Editor.Content;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.Utilities;
using Intersect.GameObjects.Maps;

namespace Intersect.Editor.Forms.Editors
{

    public partial class FrmMapType : EditorForm
    {

        private List<MapType> mChanged = new List<MapType>();

        private string mCopiedItem;

        private MapType mEditorItem;

        protected override void GameObjectUpdatedDelegate(GameObjectType type)
        {
            if (type == GameObjectType.MapType)
            {
                InitEditor();
                if (mEditorItem != null && !MapType.Lookup.Values.Contains(mEditorItem))
                {
                    mEditorItem = null;
                    UpdateEditor();
                }
            }
            else if (type == GameObjectType.Class ||
                     type == GameObjectType.Projectile ||
                     type == GameObjectType.Animation ||
                     type == GameObjectType.Spell)
            {
                FrmMapType_Load(null, null);
            }
        }

        public FrmMapType()
        {
            InitializeComponent();
            InitLocalization();
        }

        private void InitLocalization()
        {
            
        }

        public void InitEditor(TimeBase time)
        {
           
        }

        private void lblMapTypes_Click(object sender, EventArgs e)
        {

        }

        private void pnlColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlColor_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            mChangingName = true;
            mEditorItem.Name = txtName.Text;
            if (lstMapTypes.SelectedNode != null && lstMapTypes.SelectedNode.Tag != null)
            {
                lstMapTypes.SelectedNode.Text = txtName.Text;
            }

            mChangingName = false;
        }

        private void toolStripItemNew_Click(object sender, EventArgs e)
        {
            PacketSender.SendCreateObject(GameObjectType.MapType);
        }

        private void toolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstMapTypes.Focused)
            {
                if (DarkMessageBox.ShowWarning(
                        "Are you sure you want to delete this map type?", "Delete Map Type?", DarkDialogButton.YesNo,
                        Properties.Resources.Icon
                    ) ==
                    DialogResult.Yes)
                {
                    PacketSender.SendDeleteObject(mEditorItem);
                }
            }
        }

        private void btnChronological_Click(object sender, EventArgs e)
        {
            btnChronological.Checked = !btnChronological.Checked;
            InitEditor();
        }

        public void InitEditor()
        {
            var selectedId = Guid.Empty;
            var folderNodes = new Dictionary<string, TreeNode>();
            if (lstMapTypes.SelectedNode != null && lstMapTypes.SelectedNode.Tag != null)
            {
                selectedId = (Guid)lstMapTypes.SelectedNode.Tag;
            }

            lstMapTypes.Nodes.Clear();

            lstMapTypes.Sorted = !btnChronological.Checked;           

            foreach (var itm in MapType.ItemPairs)
            {
                var node = new TreeNode(itm.Value);
                node.Tag = itm.Key;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;

                lstMapTypes.Nodes.Add(node);               

                if (itm.Key == selectedId)
                {
                    lstMapTypes.SelectedNode = node;
                }
            }

            var selectedNode = lstMapTypes.SelectedNode;

            if (!btnChronological.Checked)
            {
                lstMapTypes.Sort();
            }

            lstMapTypes.SelectedNode = selectedNode;           
        }

        private void UpdateEditor()
        {
            if (mEditorItem != null)
            {
                txtName.Text = mEditorItem.Name;
                chkWalkThroughPlayers.Checked = mEditorItem.WalkThroughPlayers;
                chkAttackNpcs.Checked = mEditorItem.CanAttackNpcs;
                chkAttackPlayers.Checked = mEditorItem.CanAttackPlayers;
                chkDropItems.Checked = mEditorItem.DropItemsOnDeath;
                chkArena.Checked = mEditorItem.IsArena;
                chkTrade.Checked = mEditorItem.CanTrade;
                pnlColor.BackColor = UpdateColor(mEditorItem.MapNameColor);
                if (mChanged.IndexOf(mEditorItem) == -1)
                {
                    mChanged.Add(mEditorItem);
                    mEditorItem.MakeBackup();
                }
            }
            else
            {
                //pnlContainer.Hide();
            }

            UpdateToolStripItems();
        }

        private void UpdateToolStripItems()
        {
            toolStripItemDelete.Enabled = mEditorItem != null && lstMapTypes.Focused;
            toolStripItemUndo.Enabled = mEditorItem != null && lstMapTypes.Focused;
        }

        private void lstMapTypes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            if (node != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.Node.Tag != null && e.Node.Tag.GetType() == typeof(Guid))
                    {
                        Clipboard.SetText(e.Node.Tag.ToString());
                    }
                }

                var hitTest = lstMapTypes.HitTest(e.Location);
                if (hitTest.Location != TreeViewHitTestLocations.PlusMinus)
                {
                    if (node.Nodes.Count > 0)
                    {
                        if (node.IsExpanded)
                        {
                            node.Collapse();
                        }
                        else
                        {
                            node.Expand();
                        }
                    }
                }                
            }
        }

        private void lstMapTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (mChangingName)
            {
                return;
            }

            if (lstMapTypes.SelectedNode == null || lstMapTypes.SelectedNode.Tag == null)
            {
                return;
            }

            mEditorItem = MapType.Get((Guid)lstMapTypes.SelectedNode.Tag);
            UpdateEditor();
        }

        private void toolStripItemUndo_Click(object sender, EventArgs e)
        {
            if (mChanged.Contains(mEditorItem) && mEditorItem != null)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.ItemEditor.undoprompt, Strings.ItemEditor.undotitle, DarkDialogButton.YesNo,
                        Properties.Resources.Icon
                    ) ==
                    DialogResult.Yes)
                {
                    mEditorItem.RestoreBackup();
                    UpdateEditor();
                }
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMapType_Load(object sender, EventArgs e)
        {
            
            InitLocalization();
            UpdateEditor();
        }

        private System.Drawing.Color UpdateColor(string color)
        {
            switch (color)
            {
                case "White":
                    scrlColor.Value = 0;
                    return System.Drawing.Color.White;
                    break;

                case "Red":
                    scrlColor.Value = 1;
                    return System.Drawing.Color.Red;
                    break;

                case "Green":
                    scrlColor.Value = 2;
                    return System.Drawing.Color.Green;
                    break;

                case "Blue":
                    scrlColor.Value = 3;
                    return System.Drawing.Color.Blue;
                    break;

                case "Cyan":
                    scrlColor.Value = 4;
                    return System.Drawing.Color.Cyan;
                    break;

                case "Orange":
                    scrlColor.Value = 5;
                    return System.Drawing.Color.Orange;
                    break;

                case "Lime":
                    scrlColor.Value = 6;
                    return System.Drawing.Color.Lime;
                    break;

                case "Purple":
                    scrlColor.Value = 7;
                    return System.Drawing.Color.Purple;
                    break;

                case "Black":
                    scrlColor.Value = 8;
                    return System.Drawing.Color.Black;
                    break;

                default:
                    return System.Drawing.Color.White;
                    break;
            }
        }

        private void scrlColor_Scroll(object sender, ScrollEventArgs e)
        {
            switch (scrlColor.Value)
            {
                case 0:
                    mEditorItem.MapNameColor = "White";
                    pnlColor.BackColor = UpdateColor("White");
                    break;

                case 1:
                    mEditorItem.MapNameColor = "Red";
                    pnlColor.BackColor = UpdateColor("Red");
                    break;

                case 2:
                    mEditorItem.MapNameColor = "Green";
                    pnlColor.BackColor = UpdateColor("Green");
                    break;

                case 3:
                    mEditorItem.MapNameColor = "Blue";
                    pnlColor.BackColor = UpdateColor("Blue");
                    break;

                case 4:
                    mEditorItem.MapNameColor = "Cyan";
                    pnlColor.BackColor = UpdateColor("Cyan");
                    break;

                case 5:
                    mEditorItem.MapNameColor = "Orange";
                    pnlColor.BackColor = UpdateColor("Orange");
                    break;

                case 6:
                    mEditorItem.MapNameColor = "Lime";
                    pnlColor.BackColor = UpdateColor("Lime");
                    break;

                case 7:
                    mEditorItem.MapNameColor = "Purple";
                    pnlColor.BackColor = UpdateColor("Purple");
                    break;

                case 8:
                    mEditorItem.MapNameColor = "Black";
                    pnlColor.BackColor = UpdateColor("Black");
                    break;

                default:

                    break;
            }
        }

        private void chkWalkThroughPlayers_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.WalkThroughPlayers = chkWalkThroughPlayers.Checked;
        }

        private void chkAttackNpcs_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.CanAttackNpcs = chkAttackNpcs.Checked;
        }

        private void chkAttackPlayers_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.CanAttackPlayers = chkAttackPlayers.Checked;
        }

        private void chkDropItems_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.DropItemsOnDeath = chkDropItems.Checked;
        }

        private void pnlColor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Send Changed items
            foreach (var item in mChanged)
            {
                PacketSender.SendSaveObject(item);
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            foreach (var item in mChanged)
            {
                item.RestoreBackup();
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void chkArena_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.IsArena = chkArena.Checked;
        }

        private void chkTrade_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.CanTrade = chkTrade.Checked;
        }
    }

}
