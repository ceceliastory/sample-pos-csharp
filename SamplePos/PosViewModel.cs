using System;
using System.Windows.Input;
using Castle.Core.Internal;
using SamplePos.Purchase;

namespace SamplePos
{
    public class PosViewModel
    {
        private readonly IPurchaseService purchaseService;

        public SaveItemCommand SaveItem => new SaveItemCommand(AddItem);
        public string ItemId { get; set; }

        public PosViewModel(IPurchaseService purchaseService)
        {
            this.purchaseService = purchaseService;
        }

        private void AddItem(object parameter)
        {
            if (ItemId.IsNullOrEmpty()) return;

            Console.WriteLine("Adding item: " + ItemId);
            purchaseService.Add(ItemId);
        }

    }

    public class SaveItemCommand : ICommand
    {
        private readonly Action<object> addItemCommand;

        public SaveItemCommand(Action<object> addItemCommand)
        {
            this.addItemCommand = addItemCommand;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            addItemCommand(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
