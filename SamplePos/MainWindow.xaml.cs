using System.Windows;
using Castle.Windsor;
using SamplePos.Purchase;

namespace SamplePos
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<PosViewModel>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IPurchaseService>().ImplementedBy<PurchaseService>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IPurchaseRepository>().ImplementedBy<PurchaseRepository>());
            DataContext = container.Resolve<PosViewModel>();
        }

    }
}
