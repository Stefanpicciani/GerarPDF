using GerarPDF;
using System;


Console.WriteLine("Gerando PDF! ....");


//var teste01 = new Teste01();

//teste01.Teste();

Chamar();

static void Chamar()
{
    Teste01 teste = new Teste01();
    MemoryStream pdfStream = teste.Teste();

    // Salva o MemoryStream em um arquivo
    using (FileStream file = new FileStream("Teste01.pdf", FileMode.Create, FileAccess.Write))
    {
        pdfStream.WriteTo(file);
    }

    Console.WriteLine("PDF gerado com sucesso!");
}

