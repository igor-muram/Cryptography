# AES
Encryption and decryption of a file using the AES algorithm.<br>
The hash (with the ability to select an algorithm) from the password entered by the user is used as a key.<br>
The key is ultimately not saved anywhere.<br>
It is possible to encrypt the part of the file that is responsible for the data, that is, after encryption, the file remains a valid image and opens correctly.<br>
It is possible that a random IV is created and stored in an encrypted file, and the file remains valid.