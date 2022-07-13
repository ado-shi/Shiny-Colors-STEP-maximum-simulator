# Shiny-Colors-STEP-maximum-simulator
シャニマスのSTEPシナリオにおいて、特化パラメータの最大値を試算するためのシミュレータです。

~~セキュリティの観点上、exeファイルは置いていません。~~
各々でソースコードを確認したうえでC++コンパイルを行い、exeファイルを生成する等してください。<br>
[追記]exeファイルも置いておきますが、自環境でのコンパイル推奨です。(ネットから落としたexeファイルは不用意に実行しない方が良い)。それでも良いよって方のみ上記のexeファイルを実行してください。(DLや実行時にWindowsから怒られたりすると思いますが......)

# 注意点
- 各種アイドルの上限パネル等は未考慮です。(アイドル毎にパネルが異なり、パネル開けの処理を一意化できないので......)<br>残り団結力が分かるようになっているので、なんかいい感じに調整してください。

(例)1回目のシミュレーションで残り団結力が500
⇒団結力を16回(団結力480を消費して)SPに変換。上限パネルを開けた後2回目のシミュレーションを行う

# 使用例
## Console版
![image](https://user-images.githubusercontent.com/80242944/167307940-063acd27-8164-490d-9aaa-d601db909f12.png)
![image](https://user-images.githubusercontent.com/80242944/167307944-f376a755-37ad-4a8e-98bb-d76c3a10fd0b.png)

![image](https://user-images.githubusercontent.com/80242944/167307953-f4d2bc69-b8ca-467e-8cc2-4cb3be385b1c.png)
![image](https://user-images.githubusercontent.com/80242944/167307950-5e38ceb7-4f0b-4211-b7aa-49fd75fb0377.png)

# 既知のバグ
~~以下の点はバグを確認していますが、見て分かる内容 & 入力検証が面倒くさいので対応していません。~~ 修正対応を実施しました。
- ~~ステータスが熟練度不足で上げられないのにも関わらず、上限の成長が可能な場合、成長を行ってしまう。~~<br>修正しました

- 入力に数値以外や有り得ない数値を入力した場合、挙動がおかしくなる。<br>
⇒入力に数値以外や負の整数、int型を越える大きな整数等を入れないでください。不自然な入力によりPC等に損害が発生した場合は自己責任でお願いします。(この程度で壊れるスペックのPCなんて今日日存在しないと思いますが......)<br>[追記]入力検証を実装し、ある程度の不自然な数値、文字列であれば対応できるように修正しましたが、あり得ない数値などは基本入れないでください。何かあった場合は自己責任でお願いします。

# 備考
- クソコードなので改善等していただけるならありがたいです。
- 他言語へのリプレイスも歓迎です。
- 不具合等ありましたらご報告いただけるとありがたいです。致命的なものであれば対応いたします。
## 作者のコンパイル環境
```
Microsoft Visual Studio Community 2019
```

------------
# Windowsアプリ版 Shiny-Colors-STEP-maximum-simulator
raon555さんの特化パラメータの最大値を試算するためのシミュレータを、WindowsGUIに置き換えたツールです。
シミュレータの詳細は↑を参照ください。

## アプリ版使用例
ShinyColors_STEP_MaximumSimulator.exeを実行し、以下ステータスを各テキストボックスに入力し、「じっこう」ボタンを押下ください。
* 現在の特化ステータス(Dance特化の場合はDanceのステータス値)
* 現在の特化ステータス上限
* 特化熟練度
* 団結力
* 現在の特化ステータス成長回数
* 現在の上限成長回数

![image](https://user-images.githubusercontent.com/80242944/167307940-063acd27-8164-490d-9aaa-d601db909f12.png)
　　↓
  
![2022y07m13d_231452088](https://user-images.githubusercontent.com/109031310/178755359-2e07367e-69c0-487c-94e6-0f93ec19fde9.jpg)

　　↓
![image](https://user-images.githubusercontent.com/80242944/167307950-5e38ceb7-4f0b-4211-b7aa-49fd75fb0377.png)

## 動作環境
* OS：Windows
  * Windows10でのみ動作確認済 
    * 多分過去のOSでも動くはず... 

* プラットフォーム：.NET
  * .NET 4.7.2以上でのみ動作確認済 
    * 多分過去のVerでも動くはず .NETが一切入ってないと多分無理

## アプリ版バグ
* 数値制限はかけてませんので、各ステータスの上限は超えないようお願いします(熟練度で言えば10000以上)
** 気が向いたら直します
** 数値以外の入力(-含む)は制限かけてます
* レイアウトの色合いが若干見づらくなってます
** 酒飲みながら書いたらアルストロメリアカラーになりました
