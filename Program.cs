using System;
using System.Windows.Forms;

public class Program
{
    public static Window form = new Window();
    [STAThread]
    static void Main(string[] args)
    {
        form.FormLayout();
        Application.Run(form);
    }
}