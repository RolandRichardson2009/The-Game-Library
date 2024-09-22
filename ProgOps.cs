using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheGameLibrary_RDR_2353FA21
{
    class ProgOps
    {
        //connection string to TheGameLibrary database
        private const string CONNECT_STRING =
        @"Server=cstnt.tstc.edu;" +
         "Database=TheGameLibrary_RDR_2353FA21;" +
         "User Id=rrichardsonfa212353;" +
         "password=1600361";
        //Current orderID for this current customer
        private static int _currentCustomerOrderID;

        public static int CurrentCustomerOrderID
        {
            get { return _currentCustomerOrderID; }
            set { _currentCustomerOrderID = value; }
        }






        private static bool _newOrder = true;
        public static void setNewOrderBool()
        {
            _newOrder = false;
        }
        public static bool checkNewOrderBool()
        {
            return _newOrder;
        }
        //Used to reestablish connection once database has been closed the first time
        private static bool _databaseOpened = false;
        ////build a connection to TheGameLibrary database
        private static SqlConnection _cntTheGameLibraryDatabase = new SqlConnection(CONNECT_STRING);
        //add the command object
        private static SqlCommand _sqlTheGameLibraryCommand;
        //add the data adapter
        private static SqlDataAdapter _daTheGameLibrary = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtTheGameLibraryTable = new DataTable();
        private static StringBuilder errorMessages = new StringBuilder();
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static DataTable TheGameLibraryTable//prog ops getter
        { get { return _dtTheGameLibraryTable; } }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void OpenDatabaseTheGameLibrary()
        {
            //method to open database
            try
            {
                if (_databaseOpened == false)
                {
                    //This is run if first opening of fromShopNow
                    //open the connection to TheGameLibrary database
                    _cntTheGameLibraryDatabase.Open();
                    _databaseOpened = true;
                }
                else 
                {
                    //This is run if not first opening of fromShopNow
                    //All required items are recreated so connection can be established
                    _cntTheGameLibraryDatabase = new SqlConnection(CONNECT_STRING);
                        //add the data adapter
                        _daTheGameLibrary = new SqlDataAdapter();
                        //add the data table
                        _dtTheGameLibraryTable = new DataTable();
                        //open the connection to TheGameLibrary database
                        _cntTheGameLibraryDatabase.Open();
                        _databaseOpened = true;
                }
                //message stating that connection to database was succesful
                MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void CloseDisposeDatabaseTheGameLibrary()
        {
            //method to close database and dispose of the connection object
            try
            {
                //close connection
                _cntTheGameLibraryDatabase.Close();
                //message stating that connection to database was succesful
                MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dispose of the sql objects
                _cntTheGameLibraryDatabase.Dispose();
                _sqlTheGameLibraryCommand.Dispose();
                _daTheGameLibrary.Dispose();
                _dtTheGameLibraryTable.Dispose();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string getDescription(string upcVar)
        {
            string sqlStatement = "Select Video_Description" +
                        " From Video_Games " +
                        "WHERE Video_Game_UPC = '"+ upcVar + "'";
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            string descriptionVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
            return descriptionVar;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string calculateSubtotal()
        {
            string sqlStatement = "Select SUM(Total_Line_Cost) " +
                        " From Orders " +
                        "WHERE OrderID = " + _currentCustomerOrderID;
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            string SubtotalVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
            return SubtotalVar.ToString();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //public static void copyCurrentOrderToOrder1(string Video_Game_UPCVar, int xxxxxxxxxxxxxx, int CustomerIDVar,
        //    double pricePerUnitVar, int currentTableQuantity)
        //{

        //    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //     string sqlStatement = "Select Video_Game_UPC" +
        //                            " From Orders " +
        //                            "WHERE OrderID = " + 1 + " AND Video_Game_UPC = '" + upcVar + "'";
        //    //reset command object
        //    _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);

        //        string quantityVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
        //        //return true;

        //    //Calculate Total_Line_Cost
        //    double Total_Line_CostVar = pricePerUnitVar * quantityVar;

        //    //If UPC is not in Shopping cart already
        //    if (!checkIfInCartAlready(Video_Game_UPCVar))
        //    {
        //        //MessageBox.Show("Item is not in Orders table yet, create new order.");
        //        //Create INSERT INTO sql statement
        //        string sqlStatement = "INSERT INTO Orders " +
        //             "(OrderID, Video_Game_UPC, CustomerID, " +
        //             "Order_Quantity, Total_Line_Cost) Values(" +
        //             1 + ", '" +//OrderID
        //             Video_Game_UPCVar + "', " +//Video_Game_UPC
        //             CustomerIDVar + ", " +//CustomerID
        //             quantityVar + ", " +//Order_Quantity
        //             Total_Line_CostVar + ")";//Total_Line_Cost
        //        //reset command object
        //        _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement,
        //            _cntTheGameLibraryDatabase);
        //        //Execute INSERT INTO query
        //        Int32 recordsAffected =
        //            _sqlTheGameLibraryCommand.ExecuteNonQuery();
        //    }
        //    else
        //    {
        //        //MessageBox.Show("Item is in Orders table already, Update quantity.");
        //        //SELECT the next OrderID to use for this customers current order
        //        int currentShoppingCartQuantity = getCurrentShoppingCartQuantity(Video_Game_UPCVar);
        //        string  sqlStatement =
        //            "UPDATE Orders " +
        //            "SET Order_Quantity = " + (currentShoppingCartQuantity + Order_QuantityVar) +
        //            " WHERE Video_Game_UPC = '" + Video_Game_UPCVar + "' "+
        //            "AND OrderID = 1";
        //        //reset command object
        //        _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
        //        //Execute INSERT INTO query
        //        //_currentCustomerOrderID = int.Parse(_sqlTheGameLibraryCommand.ExecuteScalar().ToString()) + 1;
        //        _sqlTheGameLibraryCommand.ExecuteNonQuery();
        //    }
        //}
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //public static void clearOrderID1()
        //{
        //    string sqlStatement = "DELETE FROM Orders " +
        //            "WHERE OrderID = 1";
        //    _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
        //    Int32 recordsAffected =
        //        _sqlTheGameLibraryCommand.ExecuteNonQuery();
        //}






        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void clearCart()
        {
            do
            {
                string sqlStatement = "SELECT TOP(1) Video_Game_UPC " +
                "FROM Orders " +
                "WHERE OrderID = " + _currentCustomerOrderID;
                _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
                string Video_Game_UPCVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
                int Order_QuantityVar = getCurrentShoppingCartQuantity(Video_Game_UPCVar);
                int currentTableQuantity = getQuantity(Video_Game_UPCVar);
                updateVideoGamesTable(-Order_QuantityVar, Video_Game_UPCVar, currentTableQuantity);
                sqlStatement = "DELETE FROM Orders " +
                "WHERE Video_Game_UPC = '" + Video_Game_UPCVar + "' AND " +
                "OrderID = " + _currentCustomerOrderID;
                _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
                Int32 recordsAffected =
                    _sqlTheGameLibraryCommand.ExecuteNonQuery();
            } while (getShoppingCartSize() != 0);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void removeFromCart(string titleVar)
        {
            string sqlStatement = "SELECT Orders.Video_Game_UPC " +
            "FROM Orders " +
            "INNER JOIN Video_Games ON Orders.Video_Game_UPC = Video_Games.Video_Game_UPC " +
            "WHERE Video_Games.Video_Title = '" + titleVar + "' AND Orders.OrderID = " + _currentCustomerOrderID;
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            string Video_Game_UPCVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
            int Order_QuantityVar = getCurrentShoppingCartQuantity(Video_Game_UPCVar);
            int currentTableQuantity = getQuantity(Video_Game_UPCVar);
            updateVideoGamesTable(-Order_QuantityVar, Video_Game_UPCVar, currentTableQuantity);
            sqlStatement = "DELETE FROM Orders " +
            "WHERE Video_Game_UPC = '" + Video_Game_UPCVar + "' AND " +
            "OrderID = " + _currentCustomerOrderID;
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            Int32 recordsAffected =
            _sqlTheGameLibraryCommand.ExecuteNonQuery();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static int getShoppingCartSize()
        {
            string sqlStatement = "Select COUNT(OrderID)" +
                        " From Orders " +
                        "WHERE OrderID = " + _currentCustomerOrderID + "";
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            string shoppingCartSizeVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
            return int.Parse(shoppingCartSizeVar);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string getShoppingCartUPCCurrentOrder()
        {
            string sqlStatement = "Select Video_Game_UPC" +
                        " From Orders " +
                        "WHERE OrderID = " + _currentCustomerOrderID;
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            string ShoppingCartUPCCurrentOrderVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
            return ShoppingCartUPCCurrentOrderVar.ToString();
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        public static bool checkIfInCartAlready(string upcVar)
        {
            string sqlStatement = "Select Video_Game_UPC" +
                        " From Orders " +
                        "WHERE OrderID = " + _currentCustomerOrderID + " AND Video_Game_UPC = '" + upcVar + "'";
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            try 
            { 
                string quantityVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static int getQuantity(string upcVar)
        {
            string sqlStatement = "Select Video_QuantityOnHand" +
                        " From Video_Games " +
                        "WHERE Video_Game_UPC = '" + upcVar + "'";
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            string quantityVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
            return int.Parse(quantityVar);
        }
        ////////////////////////////////////////////////////////
        //This function INSERTS INTO the Orders table a new row
        public static void addOrder(
            string Video_Game_UPCVar, int Order_QuantityVar, int CustomerIDVar, 
            double pricePerUnitVar, int currentTableQuantity)
        {
            //Calculate Total_Line_Cost
            double Total_Line_CostVar = pricePerUnitVar * Order_QuantityVar;
            
            //If UPC is not in Shopping cart already
            if (!checkIfInCartAlready(Video_Game_UPCVar))
            {
                //MessageBox.Show("Item is not in Orders table yet, create new order.");
                //Create INSERT INTO sql statement
                string sqlStatement = "INSERT INTO Orders " +
                     "(OrderID, Video_Game_UPC, CustomerID, " +
                     "Order_Quantity, Total_Line_Cost) Values(" +
                     _currentCustomerOrderID + ", '" +//OrderID
                     Video_Game_UPCVar + "', " +//Video_Game_UPC
                     CustomerIDVar + ", " +//CustomerID
                     Order_QuantityVar + ", " +//Order_Quantity
                     Total_Line_CostVar + ")";//Total_Line_Cost
                //reset command object
                _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, 
                    _cntTheGameLibraryDatabase);
                //Execute INSERT INTO query
                Int32 recordsAffected = 
                    _sqlTheGameLibraryCommand.ExecuteNonQuery();
            }
            else 
            {
                //MessageBox.Show("Item is in Orders table already, Update quantity.");
                //SELECT the next OrderID to use for this customers current order
                int currentShoppingCartQuantity = getCurrentShoppingCartQuantity(Video_Game_UPCVar);
                string sqlStatement =
                    "UPDATE Orders " +
                    "SET Order_Quantity = " + (currentShoppingCartQuantity + Order_QuantityVar) +
                    " WHERE Video_Game_UPC = '" + Video_Game_UPCVar + "'";
                //reset command object
                _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
                //Execute INSERT INTO query
                //_currentCustomerOrderID = int.Parse(_sqlTheGameLibraryCommand.ExecuteScalar().ToString()) + 1;
                _sqlTheGameLibraryCommand.ExecuteNonQuery();
            }
        }
        //////////////////////////////////////////////////////////////////////
        //This function xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        public static void selectNewOrderID()
        {
            //SELECT the next OrderID to use for this customers current order
            string sqlStatement = "SELECT MAX(CAST(OrderID as INT)) FROM Orders";
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, 
                _cntTheGameLibraryDatabase);
            //Execute INSERT INTO query
            _currentCustomerOrderID = (int.Parse(
                _sqlTheGameLibraryCommand.ExecuteScalar().ToString())+1);
        }
        //////////////////////////////////////////////////////////////////////////
        public static int getNewOrderID()
        {
            return _currentCustomerOrderID;
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////
            public static int getCurrentShoppingCartQuantity(string upcVar)
        {
           
                string sqlStatement = "Select Order_Quantity" +
                                " From Orders " +
                                "WHERE Video_Game_UPC = '" + upcVar + "' " +
                                "AND OrderID = " + getNewOrderID();
                //reset command object
                _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
                string quantityVar = _sqlTheGameLibraryCommand.ExecuteScalar().ToString();
                return int.Parse(quantityVar);
        }
        ////////////////////////////////////////////////////////////////////////
        public static void updateVideoGamesTable(int Order_QuantityVar, string Video_Game_UPCVar, int currentTableQuantity)
        {
            //SELECT the next OrderID to use for this customers current order
            string sqlStatement =
                "UPDATE Video_Games " +
                "SET Video_QuantityOnHand = " + (currentTableQuantity - Order_QuantityVar) +
                " WHERE Video_Game_UPC = '" + Video_Game_UPCVar + "'";
            //reset command object
            _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
            //Execute INSERT INTO query
            _sqlTheGameLibraryCommand.ExecuteNonQuery();
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void DatabaseCommandTheGameLibraryVideoGameList(DataGridView dgvGamesList)
        {
            try
            {
                dgvGamesList.Refresh();

                    //statement for the command string
                    string sqlStatement = "Select Video_Title AS \"Title\", " +
                    "FORMAT(Video_PricePerUnit,'N2') AS \"Price\", Video_Genre AS \"Genre\", ESRB_Rating AS \"Rating\"," +
                    " SystemType AS \"System\", Video_Game_UPC AS \"UPC\"" + 
                    " From Video_Games ORDER BY Video_Title";
                    //reset command object
                    _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
                //Reset Data Adapter
                _daTheGameLibrary.Dispose();
                _daTheGameLibrary = new SqlDataAdapter();
                //establish data adapter
                _daTheGameLibrary.SelectCommand = _sqlTheGameLibraryCommand;
                //Reset Data Table
                _dtTheGameLibraryTable.Dispose();
                _dtTheGameLibraryTable = new DataTable();
                _dtTheGameLibraryTable.Clear();
                //fill data table
                _daTheGameLibrary.Fill(_dtTheGameLibraryTable);
                dgvGamesList.DataSource = _dtTheGameLibraryTable;
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////
       
        public static void DatabaseCommandTheGameLibraryShoppingCart(DataGridView dgvShoppingCart,Label lblSubtotalValue, Label lblTaxAmountValue, Label lblNetTotalValue)
        {
            try
            {
                dgvShoppingCart.Refresh();
                //statement for the command string
                string sqlStatement =
                "SELECT Video_Games.Video_Title AS 'Title', FORMAT(Video_Games.Video_PricePerUnit,'N2') AS 'Price', Orders.Order_Quantity AS 'Quantity', FORMAT(Orders.Total_Line_Cost,'N2') AS 'Total' " +
                "FROM Orders " +
                "INNER JOIN Video_Games ON Orders.Video_Game_UPC = Video_Games.Video_Game_UPC " +
                "WHERE Orders.OrderID = " + _currentCustomerOrderID;
                //reset command object
                _sqlTheGameLibraryCommand = new SqlCommand(sqlStatement, _cntTheGameLibraryDatabase);
                //Reset Data Adapter
                _daTheGameLibrary.Dispose();
                _daTheGameLibrary = new SqlDataAdapter();
                //establish data adapter
                _daTheGameLibrary.SelectCommand = _sqlTheGameLibraryCommand;
                //Reset Data Table
                _dtTheGameLibraryTable.Dispose();
                _dtTheGameLibraryTable = new DataTable();
                _dtTheGameLibraryTable.Clear();
                //fill data table
                _daTheGameLibrary.Fill(_dtTheGameLibraryTable);
                dgvShoppingCart.DataSource = _dtTheGameLibraryTable;


                try
                {
                    /////////////////
                    //Fill labels on form
                    lblSubtotalValue.Text = double.Parse(calculateSubtotal()).ToString("C2");
                    lblTaxAmountValue.Text = (double.Parse(calculateSubtotal()) * 0.0825).ToString("C2");
                    lblNetTotalValue.Text = (double.Parse(calculateSubtotal()) - (double.Parse(calculateSubtotal()) * 0.0825)).ToString("C2");
                }
                catch { }



















            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void UpdateOnCloseTheGameLibrary()
        {
            try
            {
                //save the updated employees table
                SqlCommandBuilder employeesAdapterCommands = new SqlCommandBuilder(_daTheGameLibrary);
                _daTheGameLibrary.Update(_dtTheGameLibraryTable);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
