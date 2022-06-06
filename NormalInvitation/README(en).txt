======================
Book Drop Rate Changer
======================

This mod is a cheat mod that increases or decreases the number of books dropped by enemies.

The default is to drop 2x number of books, but you may customize this multiplier as you wish.

-----------------------------
1. Precautions and Disclaimer
-----------------------------

I am not responsible for any problems or other issues that may arise from the use of this mod for any reason whatsoever.

This mod has the risk of significantly altering the game balance.

If you want to customize the degree of effect, you must edit the text file directly in JSON format.

-------------------
2. How to Customize
-------------------

1. Once you start the game and load this mod.
2. After loading, settings file named "ModSettings.json" will be created in the workshop installation folder
   (generally in the folder "C:\Program Files (x86)\Steamapps\steamapps\workshop\content\1256670").
   Settings file named "ModSettings.json" will be created.
3. You open this settings file in Notepad or any text editor.
4. You rewrite the rate for the number of books you drop.
5. You overwrite and save the settings file.
6. Settings are immediately reflected in the game.

This settings file is applied in real time even while the game is running.

The magnification of the book to be dropped is specified in the range of "0.0 to 10.0".
If you specify a value outside the range, the magnification is treated at the nearest lower or upper limit.
If an abnormal value is specified, such as one that cannot be recognized as a numerical value, it is treated as "2.0".

The actual number of books to be dropped is "{the number of books originally dropped} x {rate}".
No matter how small the magnification, at least one book will be dropped.
