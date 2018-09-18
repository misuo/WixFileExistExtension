# WixFileExistExtension

[WiX](https://github.com/wixtoolset) Preprocessor Extension allowing to check whether a file exist e.g. for inclusion into installer.

This extension solves issue [#3335](https://github.com/wixtoolset/issues/issues/3335) / [#1538](https://github.com/wixtoolset/issues/issues/1538)

## Build

Builds using Visual Studio solution. Source code in C# and implements a preprocesor extension as desribed in:

  1. [Creating a Skeleton WiX Extension](http://wixtoolset.org/documentation/manual/v3/wixdev/extensions/extension_development_simple_example.html)  

  2. [Creating a Preprocessor Extension](http://wixtoolset.org/documentation/manual/v3/wixdev/extensions/extension_development_preprocessor.html)

## Usage

In a WiX source file you can use:

    <?if $(fs.FileExist(...) = "1" ?>
    <?endif>
    
where `...` is the path to the file to examine. May itself contain WiX variables.
