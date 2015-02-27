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
using MahApps.Metro.Controls;
using System.Security.Principal;
using System.Data.SQLite;

           
namespace MyContacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //set database variables
      
        TextBox fNameTxt = new TextBox();
        TextBox lNameTxt = new TextBox();
        TextBox addressTxt = new TextBox();
        TextBox mobileTxt = new TextBox();
        TextBox mobile2Txt = new TextBox();
        TextBox officeTxt = new TextBox();
        TextBox emailTxt = new TextBox();
        TextBox fbTxt = new TextBox();
        TextBox twitterTxt = new TextBox();
        TextBox notesTxt = new TextBox();
        TextBox searchNameTxt = new TextBox();

        string dbConnectionString = @"Data Source=contacts.db;Version=3;";

        SQLiteConnection sqliteConn;

        public MainWindow()
        {
            InitializeComponent();
            string displayName = WindowsIdentity.GetCurrent().Name;
            userNameBlock.Text = displayName;
            sqliteConn = new SQLiteConnection(dbConnectionString);
            sqliteConn.Open();
           
        }

         ~MainWindow()
        {
           // sqliteConn.Close();
        }

        private void addContactsMenu(object sender, MouseButtonEventArgs e)
        {
            StackPanel contactsPanel = new StackPanel();
            StackPanel fNamePanel = new StackPanel();
            StackPanel lNamePanel = new StackPanel();
            StackPanel addressPanel = new StackPanel();
            StackPanel mobilePanel = new StackPanel();
            StackPanel mobile2Panel = new StackPanel();
            StackPanel officePanel = new StackPanel();
            StackPanel emailPanel = new StackPanel();
            StackPanel fbPanel = new StackPanel();
            StackPanel twitterPanel = new StackPanel();
            StackPanel notesPanel = new StackPanel();

            fNamePanel.Orientation = Orientation.Horizontal;
            lNamePanel.Orientation = Orientation.Horizontal;
            addressPanel.Orientation = Orientation.Horizontal;
            mobilePanel.Orientation = Orientation.Horizontal;
            mobile2Panel.Orientation = Orientation.Horizontal;
            officePanel.Orientation = Orientation.Horizontal;
            emailPanel.Orientation = Orientation.Horizontal;
            fbPanel.Orientation = Orientation.Horizontal;
            twitterPanel.Orientation = Orientation.Horizontal;
            notesPanel.Orientation = Orientation.Horizontal;

            fNamePanel.Margin = new Thickness(9, 0, 0, 0);
            lNamePanel.Margin = new Thickness(9, 5, 0, 0);
            addressPanel.Margin = new Thickness(9, 10, 0, 0);
            mobilePanel.Margin = new Thickness(9, 12, 0, 0);
            mobile2Panel.Margin = new Thickness(9, 15, 0, 0);
            officePanel.Margin = new Thickness(9, 15, 0, 0);
            emailPanel.Margin = new Thickness(9, 15, 0, 0);
            fbPanel.Margin = new Thickness(9, 15, 0, 0);
            twitterPanel.Margin = new Thickness(9, 15, 0, 0);
            notesPanel.Margin = new Thickness(9, 15, 0, 0);

            TextBlock fName = new TextBlock();
            fName.Text = "First Name";
           // fName.Margin = new Thickness(9, 0, 0, 0);
            fName.FontSize = 15;
            fName.Foreground= (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock lName = new TextBlock();
            lName.Text = "Last Name";
        //    lName.Margin = new Thickness(9, 10, 0, 0);
            lName.FontSize = 15;
            lName.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock address = new TextBlock();
            address.Text = "Address";
        //    address.Margin = new Thickness(9, 10, 0, 0);
            address.FontSize = 15;
            address.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock mobile = new TextBlock();
            mobile.Text = "Mobile";
       //     mobile.Margin = new Thickness(9, 10, 0, 0);
            mobile.FontSize = 15;
            mobile.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock mobile2 = new TextBlock();
            mobile2.Text = "Other number";
            //     mobile.Margin = new Thickness(9, 10, 0, 0);
            mobile2.FontSize = 15;
            mobile2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock office = new TextBlock();
            office.Text = "Office";
            //     mobile.Margin = new Thickness(9, 10, 0, 0);
            office.FontSize = 15;
            office.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock email = new TextBlock();
            email.Text = "Email";
            //     mobile.Margin = new Thickness(9, 10, 0, 0);
            email.FontSize = 15;
            email.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock fb = new TextBlock();
            fb.Text = "Facebook";
            //     mobile.Margin = new Thickness(9, 10, 0, 0);
            fb.FontSize = 15;
            fb.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock twitter = new TextBlock();
            twitter.Text = "Twitter";
            //     mobile.Margin = new Thickness(9, 10, 0, 0);
            twitter.FontSize = 15;
            twitter.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));

            TextBlock notes = new TextBlock();
            notes.Text = "Notes";
            //     mobile.Margin = new Thickness(9, 10, 0, 0);
            notes.FontSize = 15;
            notes.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));
           

            
            fNameTxt.Width = 300;
            fNameTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            fNameTxt.Text = "write here";
            fNameTxt.Margin = new Thickness(33,0, 0, 0);

            
            lNameTxt.Width = 300;
            lNameTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            lNameTxt.Text = "write here";
            lNameTxt.Margin = new Thickness(34, 0, 0, 0);

            
            addressTxt.Width = 300;
            addressTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            addressTxt.Text = "write here";
            addressTxt.Margin = new Thickness(51, 0, 0, 0);

            
            mobileTxt.Width = 300;
            mobileTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            mobileTxt.Text = "write here";
            mobileTxt.Margin = new Thickness(58, 0, 0, 0);

            
            mobile2Txt.Width = 300;
            mobile2Txt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            mobile2Txt.Text = "write here";
            mobile2Txt.Margin = new Thickness(12, 0, 0, 0);

            
            officeTxt.Width = 300;
            officeTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            officeTxt.Text = "write here";
            officeTxt.Margin = new Thickness(66, 0, 0, 0);

            
            emailTxt.Width = 300;
            emailTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            emailTxt.Text = "write here";
            emailTxt.Margin = new Thickness(66, 0, 0, 0);

            
            fbTxt.Width = 300;
            fbTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            fbTxt.Text = "write here";
            fbTxt.Margin = new Thickness(40, 0, 0, 0);

            
            twitterTxt.Width = 300;
            twitterTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            twitterTxt.Text = "write here";
            twitterTxt.Margin = new Thickness(56, 0, 0, 0);

            
            notesTxt.Width = 300;
            notesTxt.Foreground = (Brush)(new BrushConverter().ConvertFrom("#707070"));
            notesTxt.Text = "write here";
            notesTxt.Margin = new Thickness(60, 0, 0, 0);
            notesTxt.Height = 70;

            Button saveBtn = new Button();
            saveBtn.Content = "Save Contact";
            saveBtn.Width = 100;
            saveBtn.Height = 30;
            saveBtn.Margin = new Thickness(250, 20, 0, 0);
            saveBtn.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));
            saveBtn.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(saveBtn_MouseDown);
            

            fNamePanel.Children.Add(fName);
            fNamePanel.Children.Add(fNameTxt);

            lNamePanel.Children.Add(lName);
            lNamePanel.Children.Add(lNameTxt);

            addressPanel.Children.Add(address);
            addressPanel.Children.Add(addressTxt);

            mobilePanel.Children.Add(mobile);
            mobilePanel.Children.Add(mobileTxt);

            mobile2Panel.Children.Add(mobile2);
            mobile2Panel.Children.Add(mobile2Txt);

            officePanel.Children.Add(office);
            officePanel.Children.Add(officeTxt);

            emailPanel.Children.Add(email);
            emailPanel.Children.Add(emailTxt);

            fbPanel.Children.Add(fb);
            fbPanel.Children.Add(fbTxt);

            twitterPanel.Children.Add(twitter);
            twitterPanel.Children.Add(twitterTxt);

            notesPanel.Children.Add(notes);
            notesPanel.Children.Add(notesTxt);
            
            contactsPanel.Children.Add(fNamePanel);
            contactsPanel.Children.Add(lNamePanel);
            contactsPanel.Children.Add(addressPanel);
            contactsPanel.Children.Add(mobilePanel);
            contactsPanel.Children.Add(mobile2Panel);
            contactsPanel.Children.Add(officePanel);
            contactsPanel.Children.Add(emailPanel);
            contactsPanel.Children.Add(fbPanel);
            contactsPanel.Children.Add(twitterPanel);
            contactsPanel.Children.Add(notesPanel);
            contactsPanel.Children.Add(saveBtn);

            mainPanel.Children.Clear();
            mainPanel.Children.Add(contactsPanel);

        }

        private void saveBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string query="insert into contactDetails(fName,lName,address,mobile1,mobile2,office,email,fb,twitter,notes)"+
                "values('" + fNameTxt.Text + "','" + lNameTxt.Text + "','" + addressTxt.Text + "','" + mobileTxt.Text + "','" + mobile2Txt.Text + "','" + officeTxt.Text + "','" + emailTxt.Text + "','" + fbTxt.Text + "','" + twitterTxt.Text + "','" + notesTxt.Text + "');";
            try
            {
                SQLiteCommand sqliteComm = new SQLiteCommand(query, sqliteConn);
                sqliteComm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            //SQLiteDataReader dataReader = sqliteComm.ExecuteReader();
             MessageBox.Show("Contact Added");
        }

        private void SearchContactsMenu(object sender, MouseButtonEventArgs e)
        {
            StackPanel searchPanel = new StackPanel();
            searchPanel.Orientation = Orientation.Horizontal;
            searchPanel.Margin = new Thickness(0, 10, 0, 0);

            TextBlock searchName = new TextBlock();
            searchName.Text = "Enter Name";
            searchName.FontSize = 15;
            searchName.Foreground = (Brush)(new BrushConverter().ConvertFrom("#880880"));
            searchName.Margin = new Thickness(40, 0, 0, 0);
            

            
            searchNameTxt.Width = 250;
            searchNameTxt.Margin = new Thickness(25, 0, 0, 0);
            searchNameTxt.TextChanged += new  TextChangedEventHandler(searchName_TextInput);

            searchPanel.Children.Add(searchName);
            searchPanel.Children.Add(searchNameTxt);

            mainPanel.Children.Clear();
            mainPanel.Children.Add(searchPanel);
            

        }

        void searchName_TextInput(object sender, TextChangedEventArgs e)
        {
            string query = "select lName,email from contactDetails where fName='" + searchNameTxt.Text + "'";
            SQLiteCommand sqliteCommand = new SQLiteCommand(query,sqliteConn);
            sqliteCommand.ExecuteNonQuery();
            SQLiteDataReader dr = sqliteCommand.ExecuteReader();     

            while(dr.Read())
            {
                string data = dr.GetString(1);
               // MessageBox.Show(data);
                StackPanel results= new StackPanel();
                TextBlock name= new TextBlock();
                TextBlock email = new TextBlock();
                name.Text=searchNameTxt.Text+" "+dr.GetString(0);
                email.Text = dr.GetString(1);
                results.Children.Add(name);
                results.Children.Add(email);
                results.Margin = new Thickness(30, 30, 0, 0);
             //   mainPanel.Children.Clear();
                mainPanel.Children.Add(results);
                
            }
        }

       

        private void AllContactsMe(object sender, MouseButtonEventArgs e)
        {
            TextBlock headerLabel = new TextBlock();
            headerLabel.Text = "All Contacts";
           
           
        }
       

       
    }
}
