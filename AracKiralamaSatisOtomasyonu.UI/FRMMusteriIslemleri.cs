using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralamaSatisOtomasyonu.Core.Context;

namespace AracKiralamaSatisOtomasyonu.UI
{
    public partial class FRMMusteriIslemleri : Form
    {
        private readonly AracKiralamaSatisOtomasyonuDbContext _context;
        public FRMMusteriIslemleri()
        {
            InitializeComponent();
            _context = new AracKiralamaSatisOtomasyonuDbContext();
        }
    }
}
