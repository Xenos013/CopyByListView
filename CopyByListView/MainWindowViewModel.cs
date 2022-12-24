using System.Collections.ObjectModel;
using System.Windows;

namespace CopyByListView;

public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        MyList = new ObservableCollection<MyListItem>
        {
            new MyListItem() { FirstHalf="秋の田の　かりほの庵の　苫をあらみ", LastHalf="わが衣手は　露にぬれつつ", Writer="天智天皇"},
            new MyListItem() { FirstHalf="春すぎて　夏来にけらし　白たへの", LastHalf="ころもほすてふ　あまの香具山", Writer="持統天皇"},
            new MyListItem() { FirstHalf="あしひきの　山鳥の尾の　しだり尾の", LastHalf="ながながし夜を　ひとりかも寝む", Writer="柿本人麻呂"},
            new MyListItem() { FirstHalf="田子の浦に　うちいでて見れば　白たへの", LastHalf="富士の高嶺に　雪は降りつつ", Writer="山部赤人"},
            new MyListItem() { FirstHalf="奥山に　もみぢ踏み分け　鳴く鹿の", LastHalf="声聞く時ぞ　秋は悲しき", Writer="猿丸太夫"},
            new MyListItem() { FirstHalf="かささぎの　渡せる橋に　おく霜の", LastHalf="白きを見れば　夜ぞふけにける", Writer="中納言家持"},
            new MyListItem() { FirstHalf="あまの原　ふりさけ見れば　かすがなる", LastHalf="三笠の山に　いでし月かも", Writer="安倍仲麿"},
            new MyListItem() { FirstHalf="わが庵は　都のたつみ　しかぞ住む", LastHalf="世を宇治山と　人は言ふなり", Writer="喜撰法師"},
        };
    }

    public ObservableCollection<MyListItem> MyList { get; }

    public DelegateCommand CopyCommand => new(
        (param) =>
        {
            if (param is string text)
            {
                Clipboard.SetText(text);
                MessageBox.Show($"クリップボードにコピーしました\r\n [{text}]");
                return;
            }
        });
}
