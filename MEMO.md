# 開発用メモ

## フォルダ構成

- `\`
  - `NormalInvitation\` : LOR Invitation Editorで作成したフォルダー。XMLデータの編集兼ワークショップリリース用として使用する。
    - `Assemblies\` : MODのDLLを配置するフォルダー。ソースコードをReleaseビルドした場合、このフォルダーに出力するようにしている。
    - `Data\`
    - `Resource\`
  - `Src\` : MODのソースコードを置いたフォルダー。
    - `Assemblies\` : ソースコードをビルドするために、C#プロジェクトから外部参照するDLLを配置しているフォルダー(例えば、MOD開発に必須なゲーム本体の `Assembly-CSharp.dll` ファイルなどはここに配置されたものをC#プロジェクトから参照している)。GitHubでの公開が前提なので、オープンソースでないDLLはバージョン管理対象にしていない。個別でコピペして用意する必要がある。
    - `BookDropRateChanger\` : MOD本体のC#プロジェクトフォルダー。
