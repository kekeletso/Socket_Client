using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ClientS
{
    public partial class Form1 : Form
    {
       
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        public Form1()
        {

            try
            {
                // initialize the form
                InitializeComponent();

                // connect to the server address
                clientSocket.Connect("127.0.0.1", 8080);

                //show that its connected
                lblmsg.Text = "Client Socket Program - Server Connected ..."; 
                
            }
            catch(Exception ex)
            {
                throw new Exception("Connection error.." + ex);
            }

        }

      
        private async void btnaddress_Click(object sender, EventArgs e)
        {

            //to be used for the ping
            Ping aPing = new Ping();  
           // txtresponse.Text = "";

            try
            {
               
                //clear the txtresponse field
                txtresponse.Text = ""; 
                                
                //connect to the server
                NetworkStream serverStream = clientSocket.GetStream(); 

                // get ip address from textbox and parse it
                IPAddress ipAddress = IPAddress.Parse(txtuserip.Text); 

                // create a buffer for transmitting data
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(".");

                // time to wait for reply
                int timeout = 10000;

                // set data gateways
                PingOptions options = new PingOptions(64, true); 

                //send the ping asynchronously
                //assign response to variable
                var reply = await aPing.SendPingAsync(ipAddress, timeout, outStream, options);

                //check response 
                //assign approriate response to textbox
                if(reply.Status == IPStatus.Success)
                {

                    txtresponse.Text = "Successful";
                }
                else
                {

                    txtresponse.Text = "Failed";
                }


                
            }
            catch (PingException ex)
            {
               //MessageBox.Show("opps" , "error");
               throw new Exception("Ping error.." + ex);

            }
            
        }

       

        
    }
}
