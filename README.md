# Dot-DeCode

## Introduction
Dot DeCode is a photo encryption tool that can help you maintain the privacy of your personal photos and images. The software supports JPEG, JPG image file formats irrespective of their sizes. The application is easy to use and operate, and even a non-geek user can operate this software without any problems. Dot DeCode supports both encryption and decryption in the same interface. You can easily send email with an encrypted image, or create a self-extracting encrypted file so that the receiver can open the encrypted file on any Windows computer with Dot DeCode Software.

Using this software you can:
- Convert image into binary format.
- Convert image from binary format. Dot DeCode supports .CODE, .IDX-UBYTE3, .BIN and any other binary format. 
- Encrypt images for your friends and be sure that nobody except authorized users will see it.
- Decrypt images from your friends.


## Encryption
### How To Encrypt:

Into CODE file:
- Select the image you want to encrypt.
- Select the destination folder for your encrypted file.
- Select DotCode Format (.CODE).
- Select the image type you want to convert your image to i.e RGB or Grayscale.
- Select protection mode. (Only For .code Format).
-  Enter an exact 16 character password. (Only For .code Format using encrypt protection mode).
- Encrypt your files and be sure that nobody except authorized users will see it.

Into other binary file:
- Select the image you want to encrypt.
- Select the destination folder for your encrypted file.
- Select Other Binary Format(.BIN).
- Fill in the Height and Width of the image.
- Select the image type you want to convert your image to i.e RGB or Grayscale.
- NOTE: Files using this format(other binary files) are not encrypted with a password, they are just converted into a binary file. Anyone with Dot DeCode software can extract them without a password.


## Decryption
### How To Decrypt:

For CODE files:
- Select the encrypted file you want to decrypt.
- Select the destination folder for your decrypted image.
- Voila !!! it is as simple as that.

For other binary files:
- Select the encrypted file you want to decrypt. Binary Files have .BIN extension.
- Select the destination folder for your decrypted image.
- Set the quantity to number of images in encrypted files if more than one otherwise set it to 1.
- Fill in the appropriate Height and Width of the encrypted image.
- Select the appropriate image type ie RGB or GRAYSCALE.
- NOTE: Be sure to fill in correct values of the encrypted image.



## CODE FORMAT (.code)

### What is **.code** ?

**.code** is a custom file format created for Dot DeCode. The data is stored in a very simple file format designed for storing vectors and multidimensional matrices. Files of **.code** format have a custom icon.

### Format Of **.code** Files

<pre>                 
[OFFSET]        [TYPE]            [VALUE]          [DESCRIPTION]
                  
  0000       unsigned Byte          1/0            1 = FOR RGB; 0 = FOR GRAYSCALE;  (IMAGE TYPE) 
  0001       unsigned Byte          1/0            1 = FOR ENCRYPTION; 0 = FOR NORMAL; (PROTECTION MODE)          
  0002       unsigned Byte          ??             Number Of Images;  (Default 1)
  0003       16 bit Integer         ??             Height Of Encoded Image;
  0005       16 bit Integer         ??             Width Of Encoded Image;
  0007       unsigned Byte          ??             Pixel
  0008       unsigned Byte          ??             Pixel
  ....       ....                   ..             ....
  xxxx       unsigned Byte          ??             Pixel
</pre>               


## How To Install
- Installer is available in Dot-DeCode/IDXForm/Setup/Release/setup.exe.

## For Source Code
- Form1 is the Main Interface.
- Form1.cs is available in Dot-DeCode/IDXForm/IDXForm/Form1.cs.
- Cryptography.cs is used for Encryption and Decryption.
- Cryptography.cs is available in Dot-DeCode/IDXForm/IDXForm/Cryptography.cs.
- Detailed explanation of Cryptography.cs is given on https://github.com/crazyscoop/Encrypt-and-Decrypt-Data .



