using System;
using System.Drawing;
using System.Windows.Forms;
using DAL;
using DAL.EF;
using System.Data.Entity;
using System.Linq;

class Form1 : Form
{
    public static void Main()
    {
        IUnitOfWork unitOfWork=new UnitOfWork<EFModel>();
        Console.WriteLine(
            unitOfWork.GetRepository<objects>().GetAll().First().name);
        Console.ReadLine();
    }
}