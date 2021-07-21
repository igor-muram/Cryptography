# Digital Signature

<ul>
  <li>Keys are generated using RSA algorithm.</li>
  <li>Public key is saved as X.509 certificate (file with .cer extension).</li>
  <li>Private key is saved as PKCS #12 certificate (file with .pem extension).</li>
  <li>The file digital signature generation program accepts the file to be signed and the file with the extension .pem and saves the signature in the specified file.</li>
  <li>The program calculates the hash sum of the file using SHA-1.</li>
  <li>A program for validating the digital signature of files is implemented.</li>
</ul>
