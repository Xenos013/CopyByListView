using System;
using System.Windows.Input;

namespace CopyByListView;

public class DelegateCommand : ICommand
{
    private readonly Action<object?> _execute;

    public DelegateCommand(Action<object?> execute)
    {
        _execute = execute;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter) => _execute?.Invoke(parameter);

    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}