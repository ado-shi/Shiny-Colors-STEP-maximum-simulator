# Shiny-Colors-STEP-maximum-simulator
シャニマスのSTEPシナリオにおいて、特化パラメータの最大値を試算するためのシミュレータです。

セキュリティの観点上、exeファイルは置いていません。各々でソースコードを確認したうえでCコンパイルを行い、exeファイルを生成してください。

(セキュリティを意識するなら_CRT_SECURE_NO_WARNINGSを使うなって話ですが)
# 使用例
![image](https://user-images.githubusercontent.com/80242944/167307940-063acd27-8164-490d-9aaa-d601db909f12.png)
![image](https://user-images.githubusercontent.com/80242944/167307944-f376a755-37ad-4a8e-98bb-d76c3a10fd0b.png)

![image](https://user-images.githubusercontent.com/80242944/167307950-5e38ceb7-4f0b-4211-b7aa-49fd75fb0377.png)
![image](https://user-images.githubusercontent.com/80242944/167307953-f4d2bc69-b8ca-467e-8cc2-4cb3be385b1c.png)


# 既知のバグ
以下の点はバグを確認していますが、見て分かる内容 & 入力検証が面倒くさいので対応していません。
- ステータスが熟練度不足で上げられないのにも関わらず、上限の成長が可能な場合、成長を行ってしまう。

⇒各々の判断で対応してください
- 入力に数値以外や有り得ない数値を入力した場合、挙動がおかしくなる。

⇒入力に数値以外を入れないでください。不自然な入力によりPC等に損害が発生した場合は自己責任でお願いします。

# 備考
クソコードなので改善等していただけるならありがたいです。

他言語へのリプレイスも歓迎です。
