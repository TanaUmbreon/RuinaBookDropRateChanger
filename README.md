# Book Drop Rate Changer

ゲーム「[Library Of Ruina](https://store.steampowered.com/app/1256670/Library_Of_Ruina/)」のワークショップ対応版MOD第1弾です。

敵が落とす本の数を増減させるチート系MODです。

効果の程度はユーザー側が任意にカスタマイズできます。  
具体的には、「0.0～10.0」の倍率を指定することで落とす本の数を増やしたり減らしたりすることができます。減らす場合、落とす本の数が1冊を下回ることはありません。

## 注意事項・免責事項等

- **このMODの使用により発生した問題等は、いかなる理由があっても一切責任を負いません。**
- ゲームバランスを著しく変えてしまうリスクがあります。
- 効果の程度をカスタマイズするには、JSON形式のテキストファイルを直接編集する必要があります。

## ダウンロード・リリースノート

[「Releases」ページ](https://github.com/TanaUmbreon/RuinaBookDropRateChanger/releases) を参照してください。

## フォルダ構成

- `\`
  - `NormalInvitation\` : LOR Invitation Editorで作成したフォルダーです。XMLデータの編集兼ワークショップリリース用として使用します。
    - `Assemblies\` : MODのDLLを配置するフォルダーです。ソースコードをReleaseビルドした場合、このフォルダーにDLLが出力されます。
    - `Data\`
    - `Resource\`
  - `Src\` : MODのソースコードを置いたフォルダーです。
    - `Assemblies\` : ソースコードをビルドするために、C#プロジェクトから外部参照するDLLを配置しているフォルダーです(例えば、MOD開発に必須なゲーム本体の `Assembly-CSharp.dll` ファイルなどはここに配置されたものをC#プロジェクトから参照しています)。オープンソースでないDLLはバージョン管理対象にしていないので、個別でコピペして用意する必要があります。
    - `BookDropRateChanger\` : MOD本体のC#プロジェクトフォルダーです。
