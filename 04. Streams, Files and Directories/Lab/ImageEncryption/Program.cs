

//using (FileStream read = new FileStream("../../../Images/pro.jpg", FileMode.Open))
//{

//    using (FileStream write = new FileStream("../../../Images/[E]pro.jpg", FileMode.Create))
//    {
        
//    byte[] buffer = new byte[1024];

//    while (read.Read(buffer, 0, buffer.Length) > 0)
//    {
//        for (int i = 0; i < buffer.Length; i++)
//        {
//            buffer[i] ^= 32;
//        }

//        write.Write(buffer, 0, buffer.Length);
//    }
//    }

//}


foreach (var file in Directory.GetFiles("../../../Images"))
{
    EncryptDecrypt(file);
}





 void EncryptDecrypt(string path)
 {

     string basePath = "../../../Images/";
    using (FileStream read = new FileStream(path, FileMode.Open))
    {

        using (FileStream write = new FileStream($"{path}[E]", FileMode.Create))
        {

            byte[] buffer = new byte[1024];

            while (read.Read(buffer, 0, buffer.Length) > 0)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] ^= 32;
                }

                write.Write(buffer, 0, buffer.Length);
            }
        }

    }
}