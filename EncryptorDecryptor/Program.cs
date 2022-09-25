using EncryptorDecryptor;

Cryptor cr = new Cryptor("22222222","11111111");
string encr = cr.Encryption("Hallo mein Name ist BeneX Drake");
string decr = cr.Decryption(encr);
Console.WriteLine($"{nameof(encr)} - {encr}");
Console.WriteLine($"{nameof(decr)} - {decr}");