# Digital Signature

* Keys are generated using RSA algorithm.
* Public key is saved as X.509 certificate (file with .cer extension).
* Private key is saved as PKCS #12 certificate (file with .pem extension).
* The file digital signature generation program accepts the file to be signed and the file with the extension .pem and saves the signature in the specified file.
* The program calculates the hash sum of the file using SHA-1.
* A program for validating the digital signature of files is implemented.
