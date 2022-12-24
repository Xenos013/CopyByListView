using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CopyByListView;

public class MyListItem : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private string _firstHalf = string.Empty;
    public string FirstHalf
    {
        get => _firstHalf;
        set
        {
            _firstHalf = value;
            NotifyPropertyChanged();
        }
    }

    private string _lastHalf = string.Empty;
    public string LastHalf
    {
        get => _lastHalf;
        set
        {
            _lastHalf = value;
            NotifyPropertyChanged();
        }
    }

    private string _writer = string.Empty;
    public string Writer
    {
        get => _writer;
        set
        {
            _writer = value;
            NotifyPropertyChanged();
        }
    }

    public string Full => $"{FirstHalf}　{LastHalf}　{Writer}";
}
