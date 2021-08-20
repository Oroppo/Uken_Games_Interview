**A short Project to comply with an Interview for Uken Games. Written in C#**

*The main purpose of the project is to find the least frequent number in a given dataset of n terms from a formatted text file. If there is a collision, the lowest number sharing the same frequency is reported instead.*

To open this code for yourself, use your IDE of choice capable of running C# scripts and dig into the source code. if you simply want to check it's functionality I've left a shortcut to the main executable file here:

```Uken_Games_Interview\Interview Q1 - Text_file_reader - Shortcut```

There are 5 sample files included, 
the files are numbered 1-5 and are simple formatted text files. For the code to work, you must seperate each individual number with a line break in the text file. the text files are found within:

```Uken_Games_Interview\Interview Q1 - Text_File_reader\bin\Debug\netcoreapp3.1```

If you would like to try your own custom files, you may place them in there, if they are named differently, please ensure that the name is reflected in the function call within the C# script which looks like this.

```List<int> List1 = ReadFile("Your_filename _here");```
```CalculateFrequency("Your_filename_here", List1); ```

Alternatively, if you'd like to search from another directory, simply specify the directory you'd wish to use like so: 
```@"C:\\Your_Target_Folder"```


#####Please note: I haven't deleted the garbage files from the project yet, so there's a fair bit of bloat here.
