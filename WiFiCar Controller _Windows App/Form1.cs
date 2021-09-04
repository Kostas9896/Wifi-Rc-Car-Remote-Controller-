using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;    
using System.IO;
using AForge.Controls;

namespace ConsoleApplication2udp
{

    public partial class Form1 : Form
    {
        
        
        MJPEGStream Stream;
        UdpClient udpClient = new UdpClient();
        IPAddress IP;
       

        public Form1()
        {   
            InitializeComponent();
            stopStream.Visible = false;
            disconnect_button.Visible = false;
            this.AutoScroll = true;
            comboBoxRes.SelectedIndex = 3; // selected by default
            comboBoxWB.SelectedIndex = 0;
            pictureBox1.Size = new System.Drawing.Size(400, 296);
            comboBoxWB.Visible = false;
            WindowState = FormWindowState.Maximized;
            Thread thdUDPServer = new Thread(new ThreadStart(CheckifConnected));
            thdUDPServer.Start(); 
            Status.Text = "Disconnected";
            Status.ForeColor = System.Drawing.Color.Red; // Color Change!
           

        }
         private void CheckifConnected() 
            {
            int Port = 2020;

             while (true)
            {  String url = textBox_ip.Text.Trim();
             
              
                
            if (disconnect_button.Visible == true){
                Ping p1 = new Ping();
               PingReply PR = p1.Send(url);
                
              
                    if (PR.Status.ToString().Equals("Success") && Convert.ToInt16(textBox_port.Text) == Port)
                    {

                    }
                    else
                    { DialogResult d;
                        d=MessageBox.Show("Connection Failed!\n Application will be restart.","Important Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                      
                       Application.Restart();
                    }
            }    
            }        
        }
               
    
        
        private void Connection()
        { 
         
        String url = textBox_ip.Text.Trim();
         bool flag = IPAddress.TryParse(url, out IP);
         string[] splitValues = url.Split('.');
            if (flag==true && splitValues.Length == 4){// Ip Validation
        
                int Port = 2020;
                Ping p1 = new Ping();
          
                PingReply PR = p1.Send(url);
                if(PR.Status.ToString().Equals("Success")&& Convert.ToInt16(textBox_port.Text) == Port ){
                    udpClient.Connect(url,Convert.ToInt16(textBox_port.Text));
            
                    disconnect_button.Visible = true;
                    Connect.Visible = false;
                    Status.Text = "Connected";
                    Status.ForeColor = System.Drawing.Color.Green;
                
                }else{
                    MessageBox.Show("Connection Failed!\n Try again.","Important Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    disconnect_button.Visible = false;
                    Connect.Visible = true;
                    Status.Text = "Disconnected";
                    Status.ForeColor = System.Drawing.Color.Red;
                }
            } else{
                MessageBox.Show(url+" is not a valid IP address","Important Message",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
            
            
                
           
               
            
         }   
          
         
         private void Request(String var, int val)
            {   
            String url = textBox_ip.Text.Trim();
            String url_control = "http://" + url + "/control?var=" + var + "&val=" + val;

            if (disconnect_button.Visible==true)
            {   
                HttpWebRequest request = WebRequest.Create(url_control) as HttpWebRequest;
                
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                
            }
        }
        private void button_start_Click(object sender, EventArgs e) //Start stream 
        {
            String url = textBox_ip.Text.Trim();

            if (disconnect_button.Visible == true)
            {
                Stream = new MJPEGStream("http://" + url + ":81/stream"); //Stream url
                Stream.NewFrame += stream_NewFrame;
                Stream.Start();
                button_start.Visible = false;
                stopStream.Visible = true;
                pictureBox1.Visible = true;

            }
               


        }
        void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;

        }

        

       

        




   
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox_flash.Checked==true && disconnect_button.Visible==true)
            {        

                Byte[] senddata = Encoding.ASCII.GetBytes("ledon");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (checkBox_flash.Checked == false && disconnect_button.Visible == true)
            {        

                Byte[] senddata = Encoding.ASCII.GetBytes("ledoff");
                udpClient.Send(senddata, senddata.Length);
            }


        }


        private void StopStream_Click(object sender, EventArgs e)
        {
            Stream.Stop();
            button_start.Visible = true;
            stopStream.Visible = false;
            pictureBox1.Visible = false;
        }



        private void F_LEFT_MouseDown(object sender, MouseEventArgs e)
        {
         if(disconnect_button.Visible==true){
           
            Byte[] senddata = Encoding.ASCII.GetBytes("fl");
            udpClient.Send(senddata, senddata.Length);
         }
        }

        private void F_LEFT_MouseUp(object sender, MouseEventArgs e)
        {
            if(disconnect_button.Visible==true){
           
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void FORWARD_MouseDown(object sender, MouseEventArgs e)
        {
            if(disconnect_button.Visible==true){
           
            Byte[] senddata = Encoding.ASCII.GetBytes("f");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void FORWARD_MouseUp(object sender, MouseEventArgs e)
        {
            if(disconnect_button.Visible==true){
            
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void F_RIGHT_MouseDown(object sender, MouseEventArgs e)
        {
     
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("fr");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void F_RIGHT_MouseUp(object sender, MouseEventArgs e)
        {
           
           if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
           }
        }

        private void LEFT_MouseDown(object sender, MouseEventArgs e)
        {
          
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("l");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void LEFT_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void Stop_Button_MouseDown(object sender, MouseEventArgs e)
        {
            
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void Stop_Button_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void RIGHT_MouseDown(object sender, MouseEventArgs e)
        {
           
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("r");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void RIGHT_MouseUp(object sender, MouseEventArgs e)
        {
         
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void B_LEFT_MouseDown(object sender, MouseEventArgs e)
        {
          
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("bl");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void B_LEFT_MouseUp(object sender, MouseEventArgs e)
        {
           
           if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void BACK_MouseDown(object sender, MouseEventArgs e)
        {
            
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("b");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void BACK_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void B_RIGHT_MouseDown(object sender, MouseEventArgs e)
        {
           
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("br");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void B_RIGHT_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(disconnect_button.Visible==true){
            Byte[] senddata = Encoding.ASCII.GetBytes("s");
            udpClient.Send(senddata, senddata.Length);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            string var = "framesize";  
            if (comboBoxRes.SelectedIndex == 0)
            {
                val = 0;
                Request(var, val);
               pictureBox1.Size = new System.Drawing.Size(160, 120);
            }
            else if (comboBoxRes.SelectedIndex == 1)
            {
                val = 3;
                Request(var, val);
                pictureBox1.Size = new System.Drawing.Size(240, 176);
            }
            else if (comboBoxRes.SelectedIndex == 2)
            {
                val = 4;
                Request(var, val);
                pictureBox1.Size = new System.Drawing.Size(320, 240);
            }
            else if (comboBoxRes.SelectedIndex == 3)
            {
                val = 5;
                Request(var, val);
                pictureBox1.Size = new System.Drawing.Size(400, 296);
            }
            else if (comboBoxRes.SelectedIndex == 4)
            {
                val = 6;
                Request(var, val);
                pictureBox1.Size = new System.Drawing.Size(640, 480);
            }
            else if (comboBoxRes.SelectedIndex == 5)
            {
                val = 7;
                Request(var, val);
                pictureBox1.Size = new System.Drawing.Size(800, 600);
            }


        }





        private void checkBoxWB_CheckedChanged_1(object sender, EventArgs e)
        {     
           
            if (checkBoxWB.Checked == true)
            {
                comboBoxWB.Visible = true;
               
            }
            else
            {
                comboBoxWB.Visible = false;
            }
        }



        
        
     bool flag = false;

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e) // keyboard control
        {
            if (e.KeyCode == Keys.W)
            { 
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("f");
                udpClient.Send(senddata, senddata.Length);
                }
            }
            else if (e.KeyCode == Keys.Q)
            {
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("fl");
                udpClient.Send(senddata, senddata.Length);
                }
            }
            else if (e.KeyCode == Keys.E)
            {
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("fr");
                udpClient.Send(senddata, senddata.Length);
                }      
             }
            else if (e.KeyCode == Keys.A)
            {
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("l");
                udpClient.Send(senddata, senddata.Length);
                }
            }
            else if (e.KeyCode == Keys.X)
            {   if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if(flag==false)
                {
                flag = true;
               
               
                 Byte[] senddata = Encoding.ASCII.GetBytes("r");
                udpClient.Send(senddata, senddata.Length);
                }
            }
            else if (e.KeyCode == Keys.Z)
            {
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("bl");
                udpClient.Send(senddata, senddata.Length);
                }
            
            }
            else if (e.KeyCode == Keys.S)
            {   
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("b");
                udpClient.Send(senddata, senddata.Length);
                }
            }
            else if (e.KeyCode == Keys.C)
            {
                if(flag==false)
                {
                flag = true;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("br");
                udpClient.Send(senddata, senddata.Length);
                }
            }
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                flag = false;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (e.KeyCode == Keys.Q)
            {
                flag = false;
               
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (e.KeyCode == Keys.E)
            {
                flag = false;
                
               
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (e.KeyCode == Keys.A)
            {
                flag = false;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);

            }
            else if (e.KeyCode == Keys.X)
            {
                flag = false;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (e.KeyCode == Keys.D)
            {
                flag = false;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (e.KeyCode == Keys.Z)
            {
                flag = false;
                
               
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);

            }
            else if (e.KeyCode == Keys.S)
            {
                flag = false;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
            else if (e.KeyCode == Keys.C)
            {
                flag = false;
                
                
                Byte[] senddata = Encoding.ASCII.GetBytes("s");
                udpClient.Send(senddata, senddata.Length);
            }
        }

        private void trackBar_Quality_Scroll(object sender, EventArgs e)
        {   int val;
            String var = "quality";
            val = trackBar_Quality.Value;
            Request(var, val);
            
        }

        private void trackBar_Brightness_Scroll(object sender, EventArgs e)
        {
            int val;
            String var = "brightness";
            val = trackBar_Brightness.Value;
            Request(var, val);
        }

        private void trackBar_Contrast_Scroll(object sender, EventArgs e)
        {
            int val;
            String var = "contrast";
            val = trackBar_Contrast.Value;
            Request(var, val);
        }

        private void trackBar_Saturation_Scroll(object sender, EventArgs e)
        {
            int val;
            String var = "saturation";
            val = trackBar_Saturation.Value;
            Request(var, val);
        }

        private void comboBoxWB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String var = "wb_mode";
            int val;
            val = comboBoxWB.SelectedIndex;
            Request(var, val);
        }

        

        private void Connect_Click(object sender, EventArgs e)
        {
            
           
            Connection();
          
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
           udpClient.Close();
            Status.Text = "Disconnected";
            Status.ForeColor = System.Drawing.Color.Red;
            Connect.Visible = true;
            disconnect_button.Visible = false;
            if (disconnect_button.Visible == false && stopStream.Visible == true)
            {
                Stream.Stop();
                button_start.Visible = true;
                stopStream.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

