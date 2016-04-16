using System;
using System.Drawing;
using System.Windows.Forms;
 
public class HelloWorld : Form
{
    static public void Main ()
    {
        Application.Run (new HelloWorld ());
    }
 
    public HelloWorld ()
    {
 
        Button b = new Button ();
        b.Top=20;
        b.Width=200; 
        b.Text = "Creando modo dios!";
        b.Click += new EventHandler (Button_Click);
        Controls.Add (b);
    }
 
    private void Button_Click (object sender, EventArgs e)
    {
        
        // Specify a name for your top-level folder. 
        // string folderName = @"\";
        string folderName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        
         // top-level folder, add a name for the subfolder to folderName. 
        string pathString = System.IO.Path.Combine(folderName, "GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}");
        
        MessageBox.Show ("Modo dios listo en el escritorio!");
        //Crea el Modo Dios
        System.IO.Directory.CreateDirectory(pathString);
        
    }
}