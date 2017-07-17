using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiteDB;

namespace BT_DRS_WinForm
{
    public partial class frmArmory : Form
    {
        public frmArmory()
        {
            InitializeComponent();
        }

        private void frmArmory_Load(object sender, EventArgs e)
        {
            LoadWnEList();
            LoadAmmoList();
        }

        private void LoadWnEList()
        {
            try
            {
                lbWnE.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                    Weapons.EnsureIndex(x => x.WeaponID);

                    foreach (DS_BTDRSWeapons Weapon in Weapons.FindAll())
                    {
                        lbWnE.Items.Add(Weapon.Name);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAmmoList()
        {
            try
            {
                lbAmmo.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                    Ammos.EnsureIndex(x => x.AmmoID);

                    foreach (DS_BTDRSAmmo Ammo in Ammos.FindAll())
                    {
                        lbAmmo.Items.Add(Ammo.AmmoName + " (" + Ammo.Ammo + " rounds)");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWnE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbWnE.SelectedItems.Count > 0)
                {
                    string[] MDL = new string[3];
                    MDL = lbWnE.SelectedItem.ToString().Split('|');
                    if (MDL.Length > 0)
                    {
                        txtName.Text = MDL[0];
                        //txtCallSign.Text = MDL[1].Substring(0, MDL[1].Length - 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                Weapons.EnsureIndex(x => x.Name);

                DS_BTDRSWeapons Weapon = Weapons.FindOne(Query.EQ("Name", txtName.Text));
                if (Weapon != null)
                {
                    txtName.Text = Weapon.Name.ToString();
                    txtHeat.Text = Weapon.Heat.ToString();
                    txtDamage.Text = Weapon.Damage;
                    txtMinimum.Text = Weapon.Minimum;
                    txtShort.Text = Weapon.Short;
                    txtMedium.Text = Weapon.Medium;
                    txtLong.Text = Weapon.Long.ToString();
                    txtTons.Text = Weapon.Tons.ToString();
                    txtCrits.Text = Weapon.Crits.ToString();
                    txtWeaponType.Text = Weapon.WeaponType;
                    txtAmmo.Text = Weapon.Ammo;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAmmo.Text == "" || txtCrits.Text == "" || txtDamage.Text == "" || txtHeat.Text == "" || txtLong.Text == "" || txtMedium.Text == "" || txtMinimum.Text == "" || txtShort.Text == "" || txtTons.Text == "" || txtWeaponType.Text == "")
                {
                    MessageBox.Show("All info must be captured!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                    Weapons.EnsureIndex(x => x.Name);
                    int WeaponIDTemp;
                    DS_BTDRSWeapons WeaponSearch = Weapons.FindOne(Query.EQ("Name", txtName.Text));
                    if (WeaponSearch != null)
                    {
                        WeaponIDTemp = WeaponSearch.WeaponID;
                        Weapons.Delete(Query.EQ("Name", WeaponSearch.Name));
                        WeaponSearch.WeaponID = WeaponIDTemp;
                        WeaponSearch.Name = txtName.Text;
                        WeaponSearch.Damage = txtDamage.Text;
                        WeaponSearch.Heat = int.Parse(txtHeat.Text);
                        WeaponSearch.Minimum = txtMinimum.Text;
                        WeaponSearch.Short = txtShort.Text;
                        WeaponSearch.Medium = txtMedium.Text;
                        WeaponSearch.Long = txtLong.Text;
                        WeaponSearch.WeaponType = txtWeaponType.Text;
                        WeaponSearch.Crits = int.Parse(txtCrits.Text);
                        WeaponSearch.Tons = int.Parse(txtTons.Text);
                        WeaponSearch.Ammo = txtAmmo.Text;
                        Weapons.Insert(WeaponSearch);
                    }
                    else
                    {
                        DS_BTDRSWeapons Weapon = new DS_BTDRSWeapons
                        {
                            WeaponID = Weapons.Count() + 1,
                            Name = txtName.Text,
                            Damage = txtDamage.Text,
                            Heat = int.Parse(txtHeat.Text),
                            Minimum = txtMinimum.Text,
                            Short = txtShort.Text,
                            Medium = txtMedium.Text,
                            Long = txtLong.Text,
                            WeaponType = txtWeaponType.Text,
                            Tons = int.Parse(txtTons.Text),
                            Crits = int.Parse(txtCrits.Text),
                            Ammo = txtAmmo.Text
                        };
                        Weapons.Insert(Weapon);
                    }
                    LoadWnEList();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {

            txtName.Text = "";
            txtDamage.Text = "";
            txtHeat.Text = "";
            txtMinimum.Text = "";
            txtShort.Text = "";
            txtMinimum.Text = "";
            txtLong.Text = "";
            txtWeaponType.Text = "";
            txtCrits.Text = "";
            txtTons.Text = "";
            txtAmmo.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                Weapons.EnsureIndex(x => x.Name);

                DS_BTDRSWeapons Weapon = Weapons.FindOne(Query.EQ("Name", txtName.Text));
                if (Weapon != null)
                {
                    if (MessageBox.Show("Do you really want to delete this Equipment??? (this action cannot be undone!)", "Deleting Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Weapons.Delete(Query.EQ("Name", Weapon.Name));
                    }
                }
            }
            LoadWnEList();
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadWnEList();
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadAmmoList();
            ClearFieldsAmmo();
        }

        private void LoadAmmoEList()
        {
            try
            {
                lbAmmo.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                    Ammos.EnsureIndex(x => x.AmmoID);

                    foreach (DS_BTDRSAmmo Ammo in Ammos.FindAll())
                    {
                        lbAmmo.Items.Add(Ammo.AmmoName);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFieldsAmmo()
        {
            txtNameAmmo.Text = "";
            txtAmmoA.Text = "";
            txtTonsAmmo.Text = "";
            txtCostAmmo.Text = "";
            txtBVAmmo.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameAmmo.Text== "" || txtAmmoA.Text == "" || txtTonsAmmo.Text == "" || txtCostAmmo.Text == "" || txtBVAmmo.Text == "" )
                {
                    MessageBox.Show("All info must be captured!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                    Ammos.EnsureIndex(x => x.AmmoID);
                    int AmmoIDTemp;
                    DS_BTDRSAmmo AmmoSearch = Ammos.FindOne(Query.EQ("AmmoName", txtNameAmmo.Text.Trim()));
                    if (AmmoSearch != null)
                    {
                        AmmoIDTemp = AmmoSearch.AmmoID;
                        Ammos.Delete(Query.EQ("AmmoName", AmmoSearch.AmmoName.Trim()));
                        AmmoSearch.AmmoID = AmmoIDTemp;
                        AmmoSearch.AmmoName = txtNameAmmo.Text;
                        AmmoSearch.Tons = decimal.Parse(txtTons.Text);
                        AmmoSearch.Cost = int.Parse(txtCostAmmo.Text);
                        AmmoSearch.BV = int.Parse(txtBVAmmo.Text);
                        AmmoSearch.Ammo = txtAmmoA.Text;
                        Ammos.Insert(AmmoSearch);
                    }
                    else
                    {
                        DS_BTDRSAmmo Ammo = new DS_BTDRSAmmo
                        {
                            AmmoID = Ammos.Count() + 1,
                            AmmoName = txtNameAmmo.Text,
                            Tons = decimal.Parse(txtDamage.Text),
                            Ammo = txtHeat.Text,
                            Cost = int.Parse(txtMinimum.Text),
                            BV = int.Parse(txtShort.Text)
                            
                        };
                        Ammos.Insert(Ammo);
                    }
                    LoadAmmoList();
                    ClearFieldsAmmo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                Ammos.EnsureIndex(x => x.AmmoID);

                DS_BTDRSAmmo Ammo = Ammos.FindOne(Query.EQ("AmmoName", txtNameAmmo.Text));
                if (Ammo != null)
                {
                    if (MessageBox.Show("Do you really want to delete this Ammo??? (this action cannot be undone!)", "Deleting Ammo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Ammos.Delete(Query.EQ("AmmoName", Ammo.AmmoName));
                    }
                }
            }
            LoadAmmoList();
            ClearFieldsAmmo();
        }

        private void lbAmmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbAmmo.SelectedItems.Count > 0)
                {
                    string[] MDL = new string[3];
                    MDL = lbAmmo.SelectedItem.ToString().Split('(');
                    if (MDL.Length > 0)
                    {
                        txtNameAmmo.Text = MDL[0];
                        //txtCallSign.Text = MDL[1].Substring(0, MDL[1].Length - 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtNameAmmo_TextChanged(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                Ammos.EnsureIndex(x => x.AmmoName);

                DS_BTDRSAmmo Ammo = Ammos.FindOne(Query.EQ("AmmoName", txtNameAmmo.Text.TrimEnd()));
                if (Ammo != null)
                {
                    txtName.Text = Ammo.AmmoName.ToString();
                    txtCostAmmo.Text = Ammo.Cost.ToString();
                    txtTonsAmmo.Text = Ammo.Tons.ToString();
                    txtBVAmmo.Text = Ammo.BV.ToString();
                    txtAmmoA.Text = Ammo.Ammo.ToString();
                  

                }

            }
        }
    }
}
