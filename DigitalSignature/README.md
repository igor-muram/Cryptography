# Digital Signature
Keys are generated using RSA algorithm.<br>
Public key is saved as X.509 certificate (file with .cer extension).<br>
Private key is saved as PKCS #12 certificate (file with .pem extension).<br>
The file digital signature generation program accepts the file to be signed and the file with the extension .pem and saves the signature in the specified file.<br>
The program calculates the hash sum of the file using SHA-1.<br>
A program for validating the digital signature of files is implemented.
