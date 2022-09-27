using System.Windows.Forms;
using System;

public class Window : Form
{
    public void FormLayout()
    {
        this.Name = "Window";
        this.Text = "Window";
        this.Size = new System.Drawing.Size(500, 500);
        this.StartPosition = FormStartPosition.CenterScreen;
    }
}