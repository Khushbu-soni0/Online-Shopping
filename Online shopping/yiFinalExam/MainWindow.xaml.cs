using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace yiFinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Item> itemlist = new List<Item>();
        int tireCount = 0;
        int wiperCount = 0;
        int batteryCount = 0;
        
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbselectitemType_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("-- select item type --");
            data.Add("tires");
            data.Add("windshield wipers");
            data.Add("car batteries");
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;
        }

        private void cmbselectitemType_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var selectecdcomboitem = sender as ComboBox;
            string name = selectecdcomboitem.SelectedItem as string;
            if (name == "tires")
            {
                cleartextbox();
                lblitemname.Visibility = Visibility.Visible;
                txtitemname.Visibility = Visibility.Visible;
                lbltiremodelname.Visibility = Visibility.Visible;
                txtTireModelName.Visibility = Visibility.Visible;
                lblwheeldiameter.Visibility = Visibility.Visible;
                txtwheeldiameter.Visibility = Visibility.Visible;
                btnsave.Visibility = Visibility.Visible;
                btnload.Visibility = Visibility.Visible;
                btnSubmit.Visibility = Visibility.Visible;

                lblitemcost.Visibility = Visibility.Visible;
                lblitemcostdisplay.Visibility = Visibility.Visible;
                lblitemcostdisplay.Content = "$ " + 200;

                lblItemweight.Visibility = Visibility.Visible;
                lblitemweightdisplya.Visibility = Visibility.Visible;
                lblitemweightdisplya.Content = 30 + " Kgs";

                lblvoltage.Visibility = Visibility.Hidden;
                txtVoltage.Visibility = Visibility.Hidden;

                lbllenght.Visibility = Visibility.Hidden;
                txtlength.Visibility = Visibility.Hidden;

                lblShipping.Visibility = Visibility.Hidden;
                cmbShipping.Visibility = Visibility.Hidden;

                lblshippingprice.Visibility = Visibility.Hidden;
                lblshippingprice2.Visibility = Visibility.Hidden;

                lblTotal.Visibility = Visibility.Visible;
                lblTotalCosting.Visibility = Visibility.Visible;
                lblTotalCosting.Content = "$ " + 200;

                lblGrandTotal.Visibility = Visibility.Visible;
                lblGrandTotal2.Visibility = Visibility.Visible;
                  
            }
            else if (name == "windshield wipers")
            {

                cleartextbox();
                lblitemname.Visibility = Visibility.Visible;
                txtitemname.Visibility = Visibility.Visible;
                lbllenght.Visibility = Visibility.Visible;
                txtlength.Visibility = Visibility.Visible;
                btnsave.Visibility = Visibility.Visible;
                btnload.Visibility = Visibility.Visible;
                btnSubmit.Visibility = Visibility.Visible;

                lbltiremodelname.Visibility = Visibility.Hidden;
                txtTireModelName.Visibility = Visibility.Hidden;

                lblwheeldiameter.Visibility = Visibility.Hidden;
                txtwheeldiameter.Visibility = Visibility.Hidden;

                lblvoltage.Visibility = Visibility.Hidden;
                txtVoltage.Visibility = Visibility.Hidden;

                lblitemcost.Visibility = Visibility.Visible;
                lblitemcostdisplay.Visibility = Visibility.Visible;
                lblitemcostdisplay.Content = "$ " + 15;

                lblItemweight.Visibility = Visibility.Visible;
                lblitemweightdisplya.Visibility = Visibility.Visible;
                lblitemweightdisplya.Content = 1 + " Kgs";

                lblShipping.Visibility = Visibility.Visible;
                cmbShipping.Visibility = Visibility.Visible;

                lblshippingprice.Visibility = Visibility.Visible;
                lblshippingprice2.Visibility = Visibility.Visible;

                lblTotal.Visibility = Visibility.Visible;
                lblTotalCosting.Visibility = Visibility.Visible;
                lblTotalCosting.Content = "$ " + 0;
            }
            else if (name == "car batteries")
            {

                cleartextbox();
                lblitemname.Visibility = Visibility.Visible;
                txtitemname.Visibility = Visibility.Visible;
                lblvoltage.Visibility = Visibility.Visible;
                txtVoltage.Visibility = Visibility.Visible;
                btnsave.Visibility = Visibility.Visible;
                btnload.Visibility = Visibility.Visible;
                btnSubmit.Visibility = Visibility.Visible;

                lbltiremodelname.Visibility = Visibility.Hidden;
                txtTireModelName.Visibility = Visibility.Hidden;

                lblwheeldiameter.Visibility = Visibility.Hidden;
                txtwheeldiameter.Visibility = Visibility.Hidden;

                lbllenght.Visibility = Visibility.Hidden;
                txtlength.Visibility = Visibility.Hidden;

                lblitemcost.Visibility = Visibility.Visible;
                lblitemcostdisplay.Visibility = Visibility.Visible;
                lblitemcostdisplay.Content = "$ " + 100;

                lblItemweight.Visibility = Visibility.Visible;
                lblitemweightdisplya.Visibility = Visibility.Visible;
                lblitemweightdisplya.Content = 10 + " Kgs";

                lblShipping.Visibility = Visibility.Visible;
                cmbShipping.Visibility = Visibility.Visible;

                lblshippingprice.Visibility = Visibility.Visible;
                lblshippingprice2.Visibility = Visibility.Visible;

                lblTotal.Visibility = Visibility.Visible;
                lblTotalCosting.Visibility = Visibility.Visible;
                lblTotalCosting.Content = "$ " + 0;
            }
            else
            {

                cleartextbox();
                  lblitemname.Visibility = Visibility.Hidden; 
                  txtitemname.Visibility = Visibility.Hidden;

                    lbltiremodelname.Visibility = Visibility.Hidden;
                    txtTireModelName.Visibility = Visibility.Hidden;

                   lblwheeldiameter.Visibility = Visibility.Hidden;
                    txtwheeldiameter.Visibility = Visibility.Hidden;

                    lblvoltage.Visibility = Visibility.Hidden;
                    txtVoltage.Visibility = Visibility.Hidden;

                    lbllenght.Visibility = Visibility.Hidden;
                    txtlength.Visibility = Visibility.Hidden;
        
                    lblitemcost.Visibility = Visibility.Hidden;
                    lblitemcostdisplay.Visibility = Visibility.Hidden;
                    lblItemweight.Visibility = Visibility.Hidden;
                    lblitemweightdisplya.Visibility = Visibility.Hidden;

                    lblShipping.Visibility = Visibility.Hidden;
                    cmbShipping.Visibility = Visibility.Hidden;

                    lblshippingprice.Visibility = Visibility.Hidden;
                    lblshippingprice2.Visibility = Visibility.Hidden;

                    lblTotal.Visibility = Visibility.Hidden;
                    lblTotalCosting.Visibility = Visibility.Hidden;
                    
            }
        }

        public void cleartextbox()
        {
            txtitemname.Text = "";
            txtTireModelName.Text = "";
            txtwheeldiameter.Text = "";
            txtVoltage.Text = "";
            txtlength.Text = "";
            lblitemcostdisplay.Content = "$ " + 0;
            lblitemweightdisplya.Content = 0 + " Kgs";

        }

        private void NumericOnly(System.Object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);
        }
        
        private static bool IsTextNumeric(string str)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^0-9]");
            return reg.IsMatch(str);
        }

        private void cmbShipping_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("-- select shipping --");
            data.Add("windshield wipers");
            data.Add("car batteries");
            data.Add("No Shiping");
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;
        }

        private void cmbShipping_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var selectecdcomboitem = sender as ComboBox;
            string name = selectecdcomboitem.SelectedItem as string;
            if (name == "windshield wipers")
            {
                Windshield_Wipers wwipers = new Windshield_Wipers();
                int valint = wwipers.ShipItem(name);
                if (valint > 0)
                {
                    if (cmbselectitemType.SelectedIndex == 2)
                    {
                        lblshippingprice2.Content = "$ " + 0;
                        lblshippingprice2.Content = "$ " + valint;
                        lblTotalCosting.Content = "$ " + Convert.ToString(Convert.ToInt32(valint) + Convert.ToInt32(15));
                    }
                    else if (cmbselectitemType.SelectedIndex == 3)
                    {
                        lblshippingprice2.Content = "$ " + 0;
                        lblshippingprice2.Content = "$ " + valint;
                        lblTotalCosting.Content = "$ " + Convert.ToString(Convert.ToInt32(valint) + Convert.ToInt32(100));
                    } 
                    else
                    {
                        lblshippingprice2.Content = "$ " + 0;
                        lblTotalCosting.Content = "$ " + 200;
                    }
                }
            }
            else if (name == "car batteries")
            {
                Battery btt = new Battery();
                int valint = btt.ShipItem(name);
                if (valint > 0)
                {
                    if (cmbselectitemType.SelectedIndex == 2)
                    {
                        lblshippingprice2.Content = "$ " + 0;
                        lblshippingprice2.Content = "$ " + valint;
                        lblTotalCosting.Content = "$ " + Convert.ToString(Convert.ToInt32(valint) + Convert.ToInt32(15));
                    }
                    else if (cmbselectitemType.SelectedIndex == 3)
                    {
                        lblshippingprice2.Content = "$ " + 0;
                        lblshippingprice2.Content = "$ " + valint;
                        lblTotalCosting.Content = "$ " + Convert.ToString(Convert.ToInt32(valint) + Convert.ToInt32(100));
                    }
                    else
                    {
                        lblshippingprice2.Content = "$ " + 0;
                        //lblTotalCosting.Content = "$ " + 200;
                    }
                }
            }
            else
            {
                lblshippingprice2.Content = "$ " + 0;
                //lblTotalCosting.Content = "$ " + 200;
            }

            if (name == "No Shiping")
            {
                if (cmbselectitemType.SelectedIndex == 2)
                {
                    lblshippingprice2.Content = "$ " + 0;
                    lblTotalCosting.Content = "$ " + Convert.ToInt32(15);
                }
                else if (cmbselectitemType.SelectedIndex == 3)
                {
                    lblshippingprice2.Content = "$ " + 0;
                    lblTotalCosting.Content = "$ " + Convert.ToInt32(100);
                }
                else
                {
                    lblshippingprice2.Content = "$ " + 0;
                    //lblTotalCosting.Content = "$ " + 200;
                }
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txtitemname.Text == "")
                {
                    MessageBox.Show("Enter details first");

                }

                else
                {
                    string valitemtype = cmbselectitemType.SelectedItem.ToString();
                    string valitemname = "";
                    if (txtitemname.Text.Trim() != "")
                    {
                        valitemname = txtitemname.Text.Trim().ToString();
                    }
                    string valTireModelName = "";
                    if (txtTireModelName.Text.Trim() != "")
                    {
                        valTireModelName = txtTireModelName.Text.Trim().ToString();
                    }
                    int valwheeldiameter = 0;
                    if (txtwheeldiameter.Text.Trim() != "")
                    {
                        valwheeldiameter = Convert.ToInt32(txtwheeldiameter.Text.Trim().ToString());
                    }
                    int valVoltage = 0;
                    if (txtVoltage.Text.Trim() != "")
                    {
                        valVoltage = Convert.ToInt32(txtVoltage.Text.Trim().ToString());
                    }
                    int vallength = 0;
                    if (txtlength.Text.Trim() != "")
                    {
                        vallength = Convert.ToInt32(txtlength.Text.Trim().ToString());
                    }

                    string valremovedolar = lblitemcostdisplay.Content.ToString().Replace("$", "");
                    string valremovespace = valremovedolar.Trim().ToString().Replace(" ", "");
                    int valitemcostdisplay = Convert.ToInt32(valremovespace);

                    string valweightdisplya = lblitemweightdisplya.Content.ToString().Replace("Kgs", "");
                    string valweightdisplyapace = valweightdisplya.Trim().ToString().Replace(" ", "");
                    int valitemweightdisplya = Convert.ToInt32(valweightdisplyapace);

                    string valShipping = cmbShipping.SelectedItem.ToString();

                    string valshippingprice2dolar = lblshippingprice2.Content.ToString().Replace("$", "");
                    string valshippingprice2space = valshippingprice2dolar.Trim().ToString().Replace(" ", "");
                    int valshippingprice2 = Convert.ToInt32(valshippingprice2space);

                    string valTotalCostingdolar = lblTotalCosting.Content.ToString().Replace("$", "");
                    string valTotalCostingspace = valTotalCostingdolar.Trim().ToString().Replace(" ", "");
                    int valTotalCosting = Convert.ToInt32(valTotalCostingspace);


                    itemlist.Add(new Item()
                    {
                        itemtype = valitemtype,
                        itemname = valitemname,
                        TireModelName = valTireModelName,
                        qnty = tireCount,

                        wheeldiameter = valwheeldiameter,
                        Voltage = valVoltage,
                        length = vallength,
                        itemcostdisplay = valitemcostdisplay,
                        itemweightdisplya = valitemweightdisplya,
                        Shipping = valShipping,
                        shippingprice2 = valshippingprice2,
                        TotalCosting = valTotalCosting
                    });
                    itemlist.Count();
                    lblGrandTotal.Visibility = Visibility.Visible;
                    lblGrandTotal2.Visibility = Visibility.Visible;
                    lblGrandTotal2.Content = "";
                    int itCost = 0;
                    for (int i = 0; itemlist.Count > i; i++)
                    {
                        itCost += Convert.ToInt32(itemlist[i].TotalCosting.ToString());

                    }
                    lblGrandTotal2.Content = "$ " + itCost;
                    clearallcontrol();

                }
            }
            catch (Exception)
            { }
        }

        public void clearallcontrol()
        {
            cmbselectitemType.SelectedIndex = 0;
            txtitemname.Text = "";
            txtTireModelName.Text = "";
            txtwheeldiameter.Text = "";
            txtVoltage.Text = "";
            txtlength.Text = "";
            lblitemcostdisplay.Content = "$ " + 0;
            lblitemweightdisplya.Content = 0 + " Kgs";
            cmbShipping.SelectedIndex = 0;
            lblshippingprice2.Content = "$ " + 0;
            lblTotalCosting.Content = "$ " + 0;
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("SaveFile.xml", System.Text.Encoding.UTF8);
               
                    writer.WriteStartDocument(true);
                    writer.WriteStartElement("AllItemList");
                    for (int i = 0; itemlist.Count > i; i++)
                    {
                        writer.WriteStartElement("UserItemList");
                        writer.WriteElementString("itemtype", itemlist[i].itemtype.ToString());
                        writer.WriteElementString("itemname", itemlist[i].itemname.ToString());
                        writer.WriteElementString("TireModelName", itemlist[i].TireModelName.ToString());
                        writer.WriteElementString("wheeldiameter", itemlist[i].wheeldiameter.ToString());
                        writer.WriteElementString("Voltage", itemlist[i].Voltage.ToString());
                        writer.WriteElementString("length", itemlist[i].length.ToString());
                        writer.WriteElementString("itemcostdisplay", itemlist[i].itemcostdisplay.ToString());
                        writer.WriteElementString("itemweightdisplya", itemlist[i].itemweightdisplya.ToString());
                        writer.WriteElementString("Shipping", itemlist[i].Shipping.ToString());
                        writer.WriteElementString("shippingprice2", itemlist[i].shippingprice2.ToString());
                        writer.WriteElementString("TotalCosting", itemlist[i].TotalCosting.ToString());
                        string valshippingprice2dolar = lblGrandTotal2.Content.ToString().Replace("$", "");
                        string valshippingprice2space = valshippingprice2dolar.Trim().ToString().Replace(" ", "");
                        int valshippingprice2 = Convert.ToInt32(valshippingprice2space);
                        writer.WriteElementString("GrandTotal", valshippingprice2.ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndDocument();
                    writer.Close();
                 
            }
            catch (Exception)
            { }
        }

        private void btnload_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("SaveFile.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/AllItemList/UserItemList");
            string itemtype, itemname, TireModelName;
            int wheeldiameter, Voltage, length, itemcostdisplay, itemweightdisplya;
            string Shipping;
            int shippingprice2, TotalCosting;
            foreach (XmlNode node in nodeList)
            {
                itemtype = node.SelectSingleNode("itemtype").InnerText;

                if (itemtype == "tires")
                {
                    lblitemname.Visibility = Visibility.Visible;
                    txtitemname.Visibility = Visibility.Visible;
                    lbltiremodelname.Visibility = Visibility.Visible;
                    txtTireModelName.Visibility = Visibility.Visible;
                    lblwheeldiameter.Visibility = Visibility.Visible;
                    txtwheeldiameter.Visibility = Visibility.Visible;
                    btnsave.Visibility = Visibility.Visible;
                    btnload.Visibility = Visibility.Visible;
                    btnSubmit.Visibility = Visibility.Visible;
                    lblitemcost.Visibility = Visibility.Visible;
                    lblitemcostdisplay.Visibility = Visibility.Visible;
                    lblItemweight.Visibility = Visibility.Visible;
                    lblitemweightdisplya.Visibility = Visibility.Visible;
                    lblvoltage.Visibility = Visibility.Hidden;
                    txtVoltage.Visibility = Visibility.Hidden;
                    lbllenght.Visibility = Visibility.Hidden;
                    txtlength.Visibility = Visibility.Hidden;
                    lblShipping.Visibility = Visibility.Hidden;
                    cmbShipping.Visibility = Visibility.Hidden;
                    lblshippingprice.Visibility = Visibility.Hidden;
                    lblshippingprice2.Visibility = Visibility.Hidden;
                    lblTotal.Visibility = Visibility.Visible;
                    lblTotalCosting.Visibility = Visibility.Visible;
                    lblGrandTotal.Visibility = Visibility.Visible;
                    lblGrandTotal2.Visibility = Visibility.Visible;

                    cmbselectitemType.SelectedItem = node.SelectSingleNode("itemtype").InnerText;
                    txtitemname.Text = node.SelectSingleNode("itemname").InnerText;
                    txtTireModelName.Text = node.SelectSingleNode("TireModelName").InnerText;

                    txtwheeldiameter.Text = node.SelectSingleNode("wheeldiameter").InnerText;
                    txtVoltage.Text = node.SelectSingleNode("Voltage").InnerText;
                    txtlength.Text = node.SelectSingleNode("length").InnerText;

                    lblitemcostdisplay.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("itemcostdisplay").InnerText);
                    lblitemweightdisplya.Content = Convert.ToInt32(node.SelectSingleNode("itemweightdisplya").InnerText) + " Kgs";
                    cmbShipping.SelectedItem = node.SelectSingleNode("Shipping").InnerText;

                    lblshippingprice2.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("shippingprice2").InnerText);
                    lblTotalCosting.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("TotalCosting").InnerText);

                    lblGrandTotal2.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("GrandTotal").InnerText);

                   
                   

                }
                else if (itemtype == "windshield wipers")
                {
                 
                    lblitemname.Visibility = Visibility.Visible;
                    txtitemname.Visibility = Visibility.Visible;
                    lbllenght.Visibility = Visibility.Visible;
                    txtlength.Visibility = Visibility.Visible;
                    btnsave.Visibility = Visibility.Visible;
                    btnload.Visibility = Visibility.Visible;
                    btnSubmit.Visibility = Visibility.Visible;
                    lbltiremodelname.Visibility = Visibility.Hidden;
                    txtTireModelName.Visibility = Visibility.Hidden;
                    lblwheeldiameter.Visibility = Visibility.Hidden;
                    txtwheeldiameter.Visibility = Visibility.Hidden;
                    lblvoltage.Visibility = Visibility.Hidden;
                    txtVoltage.Visibility = Visibility.Hidden;
                    lblitemcost.Visibility = Visibility.Visible;
                    lblitemcostdisplay.Visibility = Visibility.Visible;
                    lblItemweight.Visibility = Visibility.Visible;
                    lblitemweightdisplya.Visibility = Visibility.Visible;
                    lblShipping.Visibility = Visibility.Visible;
                    cmbShipping.Visibility = Visibility.Visible;
                    lblshippingprice.Visibility = Visibility.Visible;
                    lblshippingprice2.Visibility = Visibility.Visible;
                    lblTotal.Visibility = Visibility.Visible;
                    lblTotalCosting.Visibility = Visibility.Visible;
                    lblGrandTotal.Visibility = Visibility.Visible;
                    lblGrandTotal2.Visibility = Visibility.Visible;

                    cmbselectitemType.SelectedItem = node.SelectSingleNode("itemtype").InnerText;
                    txtitemname.Text = node.SelectSingleNode("itemname").InnerText;
                    txtTireModelName.Text = node.SelectSingleNode("TireModelName").InnerText;

                    txtwheeldiameter.Text = node.SelectSingleNode("wheeldiameter").InnerText;
                    txtVoltage.Text = node.SelectSingleNode("Voltage").InnerText;
                    txtlength.Text = node.SelectSingleNode("length").InnerText;

                    lblitemcostdisplay.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("itemcostdisplay").InnerText);
                    lblitemweightdisplya.Content = Convert.ToInt32(node.SelectSingleNode("itemweightdisplya").InnerText) + " Kgs";
                    cmbShipping.SelectedItem = node.SelectSingleNode("Shipping").InnerText;

                    lblshippingprice2.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("shippingprice2").InnerText);
                    lblTotalCosting.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("TotalCosting").InnerText);

                    lblGrandTotal2.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("GrandTotal").InnerText);

                   
                }
                else if (itemtype == "car batteries")
                {
                    lblitemname.Visibility = Visibility.Visible;
                    txtitemname.Visibility = Visibility.Visible;
                    lblvoltage.Visibility = Visibility.Visible;
                    txtVoltage.Visibility = Visibility.Visible;
                    btnsave.Visibility = Visibility.Visible;
                    btnload.Visibility = Visibility.Visible;
                    btnSubmit.Visibility = Visibility.Visible;
                    lbltiremodelname.Visibility = Visibility.Hidden;
                    txtTireModelName.Visibility = Visibility.Hidden;
                    lblwheeldiameter.Visibility = Visibility.Hidden;
                    txtwheeldiameter.Visibility = Visibility.Hidden;
                    lbllenght.Visibility = Visibility.Hidden;
                    txtlength.Visibility = Visibility.Hidden;
                    lblitemcost.Visibility = Visibility.Visible;
                    lblitemcostdisplay.Visibility = Visibility.Visible;
                    lblItemweight.Visibility = Visibility.Visible;
                    lblitemweightdisplya.Visibility = Visibility.Visible;
                    lblShipping.Visibility = Visibility.Visible;
                    cmbShipping.Visibility = Visibility.Visible;
                    lblshippingprice.Visibility = Visibility.Visible;
                    lblshippingprice2.Visibility = Visibility.Visible;
                    lblTotal.Visibility = Visibility.Visible;
                    lblTotalCosting.Visibility = Visibility.Visible;
                    lblGrandTotal.Visibility = Visibility.Visible;
                    lblGrandTotal2.Visibility = Visibility.Visible;

                    cmbselectitemType.SelectedItem = node.SelectSingleNode("itemtype").InnerText;
                    txtitemname.Text = node.SelectSingleNode("itemname").InnerText;
                    txtTireModelName.Text = node.SelectSingleNode("TireModelName").InnerText;

                    txtwheeldiameter.Text = node.SelectSingleNode("wheeldiameter").InnerText;
                    txtVoltage.Text = node.SelectSingleNode("Voltage").InnerText;
                    txtlength.Text = node.SelectSingleNode("length").InnerText;

                    lblitemcostdisplay.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("itemcostdisplay").InnerText);
                    lblitemweightdisplya.Content = Convert.ToInt32(node.SelectSingleNode("itemweightdisplya").InnerText) + " Kgs";
                    cmbShipping.SelectedItem = node.SelectSingleNode("Shipping").InnerText;

                    lblshippingprice2.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("shippingprice2").InnerText);
                    lblTotalCosting.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("TotalCosting").InnerText);

                    lblGrandTotal2.Content = "$ " + Convert.ToInt32(node.SelectSingleNode("GrandTotal").InnerText);

                        
                }
                else
                {
                    cleartextbox();
                    lblitemname.Visibility = Visibility.Hidden;
                    txtitemname.Visibility = Visibility.Hidden;

                    lbltiremodelname.Visibility = Visibility.Hidden;
                    txtTireModelName.Visibility = Visibility.Hidden;

                    lblwheeldiameter.Visibility = Visibility.Hidden;
                    txtwheeldiameter.Visibility = Visibility.Hidden;

                    lblvoltage.Visibility = Visibility.Hidden;
                    txtVoltage.Visibility = Visibility.Hidden;

                    lbllenght.Visibility = Visibility.Hidden;
                    txtlength.Visibility = Visibility.Hidden;

                    lblitemcost.Visibility = Visibility.Hidden;
                    lblitemcostdisplay.Visibility = Visibility.Hidden;
                    lblItemweight.Visibility = Visibility.Hidden;
                    lblitemweightdisplya.Visibility = Visibility.Hidden;

                    lblShipping.Visibility = Visibility.Hidden;
                    cmbShipping.Visibility = Visibility.Hidden;

                    lblshippingprice.Visibility = Visibility.Hidden;
                    lblshippingprice2.Visibility = Visibility.Hidden;

                    lblTotal.Visibility = Visibility.Hidden;
                    lblTotalCosting.Visibility = Visibility.Hidden;

                    lblGrandTotal.Visibility = Visibility.Hidden;
                    lblGrandTotal2.Visibility = Visibility.Hidden;

                }
              
            }
        }

        private void btnLinq_Click(object sender, RoutedEventArgs e)
        {
            
            var query = from item in itemlist
                        select item;
            foreach (Item q in query)
            {
                if (q.itemtype == "tire")
                {
                    tireCount++;
                }
                else if (q.itemtype == "windshield wipers")
                {
                    wiperCount++;
                }
                else
                {
                    batteryCount++;
                }

                if (tireCount > wiperCount && tireCount > wiperCount)
                {
                    Console.WriteLine(q.itemtype);
                    Console.WriteLine(tireCount);
                    tbList.Text += tireCount.ToString();
                    

                }

                if (wiperCount > tireCount && wiperCount > batteryCount)
                {
                    Console.WriteLine(q.itemtype);
                    Console.WriteLine(wiperCount);
                   // tbList.Text += wiperCount;
                }

                if (batteryCount > tireCount && batteryCount > wiperCount)
                {
                    Console.WriteLine(q.itemtype);
                    Console.WriteLine(batteryCount);
                   // tbList.Text += batteryCount;

                }

                tbList.Text = q.itemtype;
                
                

                

            }



        }
    }
}
