## 参考サイト

- [Mac で C#のコードをコンパイルして実行する](https://qiita.com/matsuda_sinsuke/items/76068f4c396887459803)

## 参考書

- [基礎からしっかり学ぶ C#の教科書　第 3 版　 C# 10 対応](https://www.amazon.co.jp/dp/B09TQDHQHW)

```cs
using Internal;
using System;

class MainClass
{
    static void Main()
    {
    }
}
```

```sh
# コンパイル
mcs sample.cs

# 実行
mono sample.exe
```

## 環境
