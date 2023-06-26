using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Diagnostics;
using System.IO;
using iText.Layout;
using iText.IO.Image;
using iText.Layout.Properties;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Borders;
using Org.BouncyCastle.Ocsp;
using iText.Kernel.Geom;
using iText.IO.Font.Constants;
using System.Runtime.ConstrainedExecution;
using iText.IO.Font.Otf;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;

namespace GerarPDF
{
    public class PDFModel
    {
        // Page One
        public string? Language { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? SubtitleText { get; set; }

        public string? Title1 { get; set; }
        public string? Paragraph1 { get; set; }

        public string? Title2 { get; set; }
        public string? Paragraph2 { get; set; }

        public string? Title3 { get; set; }
        public string? Paragraph3 { get; set; }

        public string? Title4 { get; set; }
        public string? Paragraph4 { get; set; }

        public string? Title5 { get; set; }
        public string? Paragraph5 { get; set; }

        public string? ExteriorColor { get; set; }
        public string? InteriorColor { get; set; }
        public string? TextFooter1 { get; set; }


        //Page Two
        public string? Param08 { get; set; }
        public string? Param09 { get; set; }
        public string? Param10 { get; set; }
        public string? Param11 { get; set; }
        public string? Param12 { get; set; }
        public string? Param13 { get; set; }
        public string? Param14 { get; set; }
        public string? Param15 { get; set; }
        public string? Param16 { get; set; }
        public string? Param17 { get; set; }
        public string? Param18 { get; set; }
        public string? Param19 { get; set; }
        public string? Param20 { get; set; }
        public string? Param21 { get; set; }
        public string? Param22 { get; set; }
        public string? Param23 { get; set; }
    }
  

    public class Teste01
    {

        public MemoryStream Teste()
        {
            //#################### ELE ESCREVE NO DIRETÓRIO O PDF GERADO E ABRE APÓS ESCREVÊ-LO

            //string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "teste.pdf");
            //var name = Guid.NewGuid().ToString();
            //var pdfPath = $@"C:\\pdf\{name}_teste.pdf";


            //PdfWriter writer = new PdfWriter(pdfPath);
            //PdfDocument pdf = new PdfDocument(writer);
            //Document document = new Document(pdf, PageSize.A4);
            //document.SetMargins(5, 20, 0, 20);


            //#################### ELE ESCREVE NO DIRETÓRIO O PDF GERADO E ABRE APÓS ESCREVÊ-LO / Ao final está adaptado para emitir em memóeria e comentado a criar em diretório

            //var stream = new MemoryStream();

            //// Crie um documento intermediário
            //PdfWriter tempWriter = new PdfWriter(new MemoryStream());
            //PdfDocument tempPdf = new PdfDocument(tempWriter);
            //Document tempDocument = new Document(tempPdf);
            //tempDocument.SetMargins(5, 20, 0, 20);



            //var nameResult = Guid.NewGuid().ToString();

            //var name = "InfoMafirol_product_" + nameResult.Substring(0, 2) + ".pdf";


            //PdfWriter writer = new PdfWriter(stream);
            //PdfDocument pdf = new PdfDocument(writer);
            //Document document = new Document(pdf, PageSize.A4);
            //document.SetMargins(5, 20, 0, 20);




            //############################### BEGIN ##########################################


            // Crie um MemoryStream para o PdfWriter
            MemoryStream tempMemoryStream = new MemoryStream();

            // Crie um documento intermediário
            PdfWriter tempWriter = new PdfWriter(tempMemoryStream);
            PdfDocument tempPdf = new PdfDocument(tempWriter);
            Document tempDocument = new Document(tempPdf);





            //-------------------------------- COLOR ------------------------------------

            //// Defina uma cor personalizada
            Color customColor = new DeviceRgb(13, 53, 81); // RGB para azul
            Color customColor1 = new DeviceRgb(48, 135, 100); // RGB para verde
            Color customColor3 = new DeviceRgb(14, 54, 81); // RGB para azul paragrafo titulo


            //-------------------------------- FONTS ------------------------------------

            string fontPath1 = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "fonts", "FUTURA HEAVY FONT.TTF");
            PdfFont font1 = PdfFontFactory.CreateFont(fontPath1, PdfEncodings.IDENTITY_H);

            string fontPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "fonts", "FuturaBookBT.ttf");
            PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

            string fontPath3 = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "fonts", "GOTHAMLIGHT (1).TTF");
            PdfFont font3 = PdfFontFactory.CreateFont(fontPath3, PdfEncodings.IDENTITY_H);

            string fontPath4 = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "fonts", "GOTHAMBOOK.TTF");
            PdfFont font4 = PdfFontFactory.CreateFont(fontPath4, PdfEncodings.IDENTITY_H);


            //################################################################### PRIMEIRA PÁGINA #################################################################################################

            //-------------------------------- HEADER ------------------------------------

            Paragraph header = new Paragraph("ULTAR")
                .SetRelativePosition(1, 0, 40, 14)
                //.SetTextAlignment(TextAlignment.CENTER)
                //.SetMargins(0 ,0 ,0 ,0)
                //.SetMarginBottom(0)
                //.SetPaddingBottom(0)
                //.SetPaddings( 0, 0 ,0 ,0)
                .SetFontColor(customColor)
                .SetFont(font)
                .SetFontSize(75);
            tempDocument.Add(header);

            Paragraph subHeader1 = new Paragraph("MURAL REFRIGERADO COM PORTAS")
               .SetRelativePosition(5, 0, 40, 62)
               .SetMarginTop(0)
               .SetPaddingTop(0)
               .SetMarginBottom(0)
               .SetPaddingBottom(0)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFont(font4)
               .SetFontSize(11);
            tempDocument.Add(subHeader1);



            Paragraph subHeader2 = new Paragraph("CARNE | LÁCTEOS | FRUTA E VEGETAIS")
               .SetRelativePosition(5, 0, 30, 65)
               .SetMarginTop(0)
               .SetPaddingTop(0)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFontColor(customColor3)
               .SetFont(font1)
               .SetFontSize(12);
            tempDocument.Add(subHeader2);


            Div div1 = new Div();
            div1.SetWidth(UnitValue.CreatePercentValue(100));  // 50% da largura total
            div1.SetBorderBottom(new SolidBorder(0.4f));
            div1.SetMarginBottom(5);  // espaço abaixo da linha
            div1.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            div1.SetRelativePosition(5, 0, 30, 69);

            tempDocument.Add(div1);

            //-------------------------------- BODY ------------------------------------

            int w = 40;
            int ml = 8;


            // ############################################# IMAGEM ##########################################################
            //string imagePaths = "https://mm.mafirol.info/Categories/Subfamilies/20230427084848996_d088e2aa-01e4-43e5-bbfe-2822e06e2911.png"; // Altere para a URL da imagem ou caminho local
            //string imagePaths = "https://mm.mafirol.info/Categories/Subfamilies/20230609074430920_5ccc7720-0ec9-44e2-9cca-deef438064bb.png"; // Altere para a URL da imagem ou caminho local
            string imagePaths = "https://mm.mafirol.info/Categories/Subfamilies/20230607152016175_ef9729b0-fd42-4173-9e2d-0ce8bd29ac4e.png"; // Altere para a URL da imagem ou caminho local
            ImageData imageDatas = ImageDataFactory.Create(imagePaths);
            Image images = new Image(imageDatas);

            // Você pode alterar a escala da imagem de acordo com suas necessidades
            images.ScaleAbsolute(410, 310);
            // Defina a posição da imagem (x, y) no temptempDocumento
            images.SetFixedPosition(230, 400);

            tempDocument.Add(images);

            //##################################################### BLOCO ABAIXO DA IMAGEM PRINCIPAL, DIVISÃO E TEXTO ########################################################################

            Paragraph body00 = new Paragraph("COR EXTERIOR STANDARD")
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                //.SetRelativePosition(ml, 70, 0, 0) // Ajustado
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetFixedPosition(350, 350, 200) // Usando SetFixedPosition
                .SetFont(font1)
                .SetFontColor(customColor1);
            tempDocument.Add(body00);

            //-------------- linha separadora--
            Div div00 = new Div();
            div00.SetWidth(UnitValue.CreatePercentValue(43));
            div00.SetBorderBottom(new SolidBorder(0.5f));
            div00.SetMarginBottom(5);
            div00.SetFixedPosition(350, 350, 200);
            div00.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            tempDocument.Add(div00);
            //--------

            // Cria uma tabela com 4 colunas (ajuste conforme necessário)
            Table table = new Table(4);

            // Lista de URLs das imagens
            List<string> imageUrlsExt = new List<string>
            {
                "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1012.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1013.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1021.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1037.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2001.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2002.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2008.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3000.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3016.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5000.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5015.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5023.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5010.png",  
             
                                             
                // ...
            };

            int count = 0;

            foreach (string url in imageUrlsExt)
            {
                if (count >= 12)
                    break;

                ImageData imageData00 = ImageDataFactory.Create(url);
                Image image00 = new Image(imageData00);
                image00.ScaleToFit(40, 40); // Ajuste o tamanho conforme necessário

                // Adiciona a imagem a uma célula e adiciona a célula à tabela
                Cell cell = new Cell().Add(image00);
                cell.SetBorder(Border.NO_BORDER);  // Remove a borda
                cell.SetPadding(5);  // Adiciona um espaço entre as células
                table.AddCell(cell);

                count++;
            }

            // Posiciona a tabela no tempDocumento
            table.SetFixedPosition(350, 200, 200);
            tempDocument.Add(table);


            //##################################################### BLOCO 02 ABAIXO DA IMAGEM PRINCIPAL, DIVISÃO E TEXTO ########################################################################

            Paragraph body02 = new Paragraph("COR Interior STANDARD".ToUpper())
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetFixedPosition(350, 165, 200) // Usando SetFixedPosition
                .SetFont(font1)
                .SetFontColor(customColor1);
            tempDocument.Add(body02);

            //-------------- linha separadora--
            Div div001 = new Div();
            div001.SetWidth(UnitValue.CreatePercentValue(43));
            div001.SetBorderBottom(new SolidBorder(0.5f));
            div001.SetMarginBottom(5);
            div001.SetFixedPosition(350, 165, 200);
            div001.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            tempDocument.Add(div001);
            //--------

            // Cria uma tabela com 4 colunas (ajuste conforme necessário)
            Table table02 = new Table(4);

            // Lista de URLs das imagens
            List<string> imageUrlsInt = new List<string>
            {
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1012.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1013.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1021.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1037.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2001.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2002.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2008.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3000.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3016.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5000.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5015.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5023.png",
                  "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5010.png",                
                                        
                // ...
            };

            int counter = 0;

            foreach (string url in imageUrlsInt)
            {
                if (counter >= 8)
                    break;

                ImageData imageData02 = ImageDataFactory.Create(url);
                Image image02 = new Image(imageData02);
                image02.ScaleToFit(40, 40); // Ajuste o tamanho conforme necessário

                // Adiciona a imagem a uma célula e adiciona a célula à tabela
                Cell cell02 = new Cell().Add(image02);
                cell02.SetBorder(Border.NO_BORDER);  // Remove a borda
                cell02.SetPadding(5);  // Adiciona um espaço entre as células
                table02.AddCell(cell02);

                counter++;
            }

            // Posiciona a tabela no tempDocumento
            table02.SetFixedPosition(350, 65, 200);
            tempDocument.Add(table02);

            //##################################################### BLOCO 1 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body = new Paragraph("DESCRIÇÃO GERAL")
                .SetWidth(70)
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.LEFT)
                .SetRelativePosition(1, 0, 30, 44)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetMarginLeft(ml)
                .SetMarginTop(0)
                .SetFont(font1)
                .SetFontColor(customColor1);
            tempDocument.Add(body);

            //-------------- linha separadora--

            Div div = new Div();
            div.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div.SetBorderBottom(new SolidBorder(0.5f));
            div.SetMarginBottom(5);  // espaço abaixo da linha
            div.SetMarginLeft(0);
            div.SetRelativePosition(1, -50, 30, 5);
            div.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            tempDocument.Add(div);
            //--------


            Paragraph paragraph1 = new Paragraph("Lorem Ipsum is simply dummy text of " +
                "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,Lorem Ipsum is simply dummy text of " +
                "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
                .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraph1);



            //##################################################### BLOCO 2 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body2 = new Paragraph("SISTEMA DE REFRIGERAÇÃO")
                .SetWidth(70)
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.LEFT)
                .SetRelativePosition(1, 0, 30, 44)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetMarginLeft(ml)
                .SetMarginTop(0)
               .SetFont(font1)
               .SetFontColor(customColor1);
            tempDocument.Add(body2);

            //-------------- linha separadora--
            Div div01 = new Div();
            div01.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div01.SetBorderBottom(new SolidBorder(0.5f));
            div01.SetMarginBottom(5);  // espaço abaixo da linha
            div01.SetMarginLeft(0);
            div01.SetRelativePosition(1, -50, 30, 5);
            div01.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            tempDocument.Add(div01);
            //--------


            Paragraph paragraph2 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraph2);

            //##################################################### BLOCO 3 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body3 = new Paragraph("SISTEMA ELÉTRICO,\r\nCOMANDO E REGULAÇÃO")
                .SetWidth(70)
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.LEFT)
                .SetRelativePosition(1, 0, 30, 44)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetMarginLeft(ml)
                .SetMarginTop(0)
               .SetFont(font1)
               .SetFontColor(customColor1);
            tempDocument.Add(body3);

            //-------------- linha separadora--
            Div div03 = new Div();
            div03.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div03.SetBorderBottom(new SolidBorder(0.5f));
            div03.SetMarginBottom(5);  // espaço abaixo da linha
            div03.SetMarginLeft(0);
            div03.SetRelativePosition(1, -50, 30, 5);
            div03.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            tempDocument.Add(div03);
            //--------

            Paragraph paragraph3 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraph3);

            //##################################################### BLOCO 4 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body4 = new Paragraph("COMPLEMENTOS")
                .SetWidth(70)
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.LEFT)
                .SetRelativePosition(1, 0, 30, 44)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetMarginLeft(ml)
                .SetMarginTop(0)
               .SetFont(font1)
               .SetFontColor(customColor1);
            tempDocument.Add(body4);

            //-------------- linha separadora--
            Div div04 = new Div();
            div04.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div04.SetBorderBottom(new SolidBorder(0.5f));
            div04.SetMarginBottom(5);  // espaço abaixo da linha
            div04.SetMarginLeft(0);
            div04.SetRelativePosition(1, -50, 30, 5);
            div04.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            tempDocument.Add(div04);
            //--------

            Paragraph paragraph4 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem y. Lorem Ipsum has been the industry's standard dummy text ever since " +
               "Ipsum has been the industry's standard dummy text ever since the 1500s, ")
                .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraph4);

            //##################################################### BLOCO 5 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body5 = new Paragraph("OPÇÕES")
                 .SetWidth(70)
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.LEFT)
                .SetRelativePosition(1, 0, 30, 44)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetMarginLeft(ml)
                .SetMarginTop(0)
               .SetFont(font1)
               .SetFontColor(customColor1);
            tempDocument.Add(body5);

            //-------------- linha separadora--
            Div div05 = new Div();
            div05.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div05.SetBorderBottom(new SolidBorder(0.5f));
            div05.SetMarginBottom(5);  // espaço abaixo da linha
            div05.SetMarginLeft(0);
            div05.SetRelativePosition(1, -50, 30, 5);
            div05.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            tempDocument.Add(div05);
            //--------


            Paragraph paragraph5 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraph5);



            //-------------------------------- FOOTER ------------------------------------


            Div divfooter = new Div();
            divfooter.SetWidth(UnitValue.CreatePercentValue(100));  // 50% da largura total
            divfooter.SetBorderBottom(new SolidBorder(0.4f));
            divfooter.SetMarginBottom(5);  // espaço abaixo da linha
            divfooter.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            divfooter.SetRelativePosition(5, 70, 30, 69);

            //tempDocument.Add(divfooter);

            Paragraph paragraphFooter = new Paragraph("Especificações sujeitas a alterações sem aviso prévio. Documento não contratual.")
               .SetFontSize(6)
               .SetMarginLeft(38)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER)
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetRelativePosition(1, 65, 30, 90)
               .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraphFooter);


            Paragraph mafirolCom0 = new Paragraph(".mafirol.com")
            .SetFontSize(8)
            //.SetFont(fontBold)
            .SetMarginLeft(38)
            .SetHorizontalAlignment(HorizontalAlignment.CENTER)
            .SetWidth(UnitValue.CreatePercentValue(50))
            .SetRelativePosition(158, 77, 40, 100)
            //.SetFontFamily() .SetTextAlignment(TextAlignment.CENTER)
            .SetFontColor(ColorConstants.GRAY);
            tempDocument.Add(mafirolCom0);
            //##################################### IMAGEM 1 FOOTERS ############################################################


            string imagePath = "https://mm.mafirol.info/assinaturas/Mafirol_mir.png";
            ImageData imageData = ImageDataFactory.Create(imagePath);
            Image img = new Image(imageData);

            img.ScaleAbsolute(130, 120);  // ajuste esses valores conforme necessário
            img.SetFixedPosition(1, 240, 2, 380);

            //img03.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            //img03.SetFixedPosition(2, 290, 2, 1200);

            Paragraph footer = new Paragraph().Add(img).SetTextAlignment(TextAlignment.CENTER);
            tempDocument.Add(footer);



            //##################################### IMAGEM 2 FOOTERS ############################################################

            string imagePath08 = "https://mm.mafirol.info/assinaturas/WWW.png";
            ImageData imageDatar08 = ImageDataFactory.Create(imagePath08);
            Image img08 = new Image(imageDatar08);

            img08.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            img08.SetFixedPosition(1, 290, 7, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer08 = new Paragraph().Add(img08).SetTextAlignment(TextAlignment.CENTER);
            tempDocument.Add(footer08);



            //################################################################### SEGUNDA PÁGINA #################################################################################################

            // Adiciona nova página
            tempDocument.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

            tempDocument.Add(header);
            tempDocument.Add(subHeader1);
            tempDocument.Add(subHeader2);
            tempDocument.Add(div1);

            //#####################################################################  ---------  BODY --------   ###################################################################################

            // Cria um objeto de imagem
            string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230524135250806_92d9f97f-c500-483d-a744-f5a757ef9295.png"; // Altere para a URL da imagem ou caminho local
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230309113554775_553e1c22-3eca-4a47-84ee-d5782b80c048.png";
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230508134640521_0d9ae880-59f2-4fe5-ab8c-ce9193f9bf0d.png";
            ImageData imageDatar = ImageDataFactory.Create(imagePathr);
            Image imager = new Image(imageDatar);

            // Você pode alterar a escala da imagem de acordo com suas necessidades
            imager.ScaleAbsolute(490, 390);

            // Defina a posição da imagem (x, y) no tempDocumento         
            imager.SetRelativePosition(40, -70, 40, 800);
            tempDocument.Add(imager);

            Paragraph body6 = new Paragraph("INFORMAÇÃO TÉCNICA")
              .SetWidth(70)
              .SetWidth(UnitValue.CreatePercentValue(w))
              .SetHorizontalAlignment(HorizontalAlignment.CENTER)
              .SetRelativePosition(1, 0, 30, 110)
              .SetTextAlignment(TextAlignment.CENTER)
              .SetFontSize(16)
              .SetMarginLeft(ml)
              .SetMarginTop(0)
             .SetFont(font1)
             .SetFontColor(customColor1);
            tempDocument.Add(body6);

            //-------------- linha separadora--
            Div div06 = new Div();
            div06.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div06.SetBorderBottom(new SolidBorder(0.5f));
            div06.SetMarginBottom(5);  // espaço abaixo da linha
            div06.SetMarginLeft(0);
            div06.SetRelativePosition(1, -114, 30, 5);
            div06.SetHorizontalAlignment(HorizontalAlignment.CENTER);  // Centraliza a Div
            tempDocument.Add(div06);
            //--------

            //PDFModel models = new PDFModel();

            //var model = models.model;

            //switch (model)
            //{               
            //    case "ES":
            //        model = "MODELO";
            //        break;
            //    case "PT":
            //        model = "MODELO";
            //        break;
            //    case "EN":
            //        model = "MODEL";
            //        break;
            //    case "FR":
            //        model = "MODÈLE";
            //        break;          
              
            //    default:
            //        break;
            //}

            

            Paragraph para1 = new Paragraph("MODELO")
                .SetMarginRight(0).SetPaddingRight(0).SetMarginBottom(2)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                   .SetFontSize(11)
                   .SetMarginLeft(40) 
                   .SetMarginBottom(5) 
                   .SetFont(font4)
                   .SetFontColor(customColor1)
             .SetFixedPosition(2, 20, 330, 276);
            tempDocument.Add(para1);

            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables01 = new Table(4);

            // Crie um objeto de cor para a cor da fonte
            PdfFont fonts = PdfFontFactory.CreateFont();
            Color fontColor = new DeviceRgb(255, 255, 255); // Branco
            Color cellColor = new DeviceRgb(105, 105, 105); // Cinza Escuro

            // Ajuste o tamanho e a cor das células
            Cell cell1 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(5) // Ajuste o preenchimento da célula
                .SetMargin(5)
                .SetBorder(Border.NO_BORDER) // Remova a borda
                .SetBackgroundColor(cellColor) // Ajuste a cor de fundo
                .Add(new Paragraph("1250")
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor));

             Cell cell2 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(5) // Ajuste o preenchimento da célula
                 .SetMargin(5)
                .SetBorder(Border.NO_BORDER) // Remova a borda
                .SetBackgroundColor(cellColor) // Ajuste a cor de fundo
                .SetFont(fonts)
                  .SetFontSize(6)
                .SetFontColor(fontColor)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("1875"));

             Cell cell3 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(5) // Ajuste o preenchimento da célula
                 .SetMargin(5)
                .SetBorder(Border.NO_BORDER) // Remova a borda
                .SetBackgroundColor(cellColor) // Ajuste a cor de fundo
                .SetFont(fonts)
                  .SetFontSize(6)
                .SetFontColor(fontColor)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("2500"));

            Cell cell4 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula
                .SetMargin(5)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetBackgroundColor(cellColor) // Ajuste a cor de fundo
               .SetFont(fonts)
                 .SetFontSize(6)
               .SetFontColor(fontColor)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3750"));



            // Adicione as células à linha
            tables01.AddCell(cell1);
            tables01.AddCell(cell2);
            tables01.AddCell(cell3);
            tables01.AddCell(cell4);


            tables01.SetFixedPosition(2, 326, 330, 120);
           
            tempDocument.Add(tables01);

            //###### Label 2

            Paragraph para2 = new Paragraph("Área total de exposição (TDA) (m2)")
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 315, 276);
            tempDocument.Add(para2);

            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables02 = new Table(4);
            Color fontColor02 = new DeviceRgb(0, 0, 0); // Preto
            Color cellColor02 = new DeviceRgb(255, 255, 255); // Branco


            // Ajuste o tamanho e a cor das células
            Cell cells01 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(5) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda             
                .Add(new Paragraph("1.88")
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02));

            Cell cells02 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula
                .SetMargin(5)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
                 .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("2.82"));

            Cell cells03 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula
                .SetMargin(5)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
                 .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3.76"));

            Cell cells04 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula
                .SetMargin(5)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
                 .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("5.64"));



            // Adicione as células à linha
            tables02.AddCell(cells01);
            tables02.AddCell(cells02);
            tables02.AddCell(cells03);
            tables02.AddCell(cells04);


            tables02.SetFixedPosition(2, 325, 310, 120);

            tempDocument.Add(tables02);



            Paragraph para3 = new Paragraph("Superfície de refrigerada (m 2)")
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 300, 276);
            tempDocument.Add(para3);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables03 = new Table(4);
            Color cellColor2 = new DeviceRgb(192, 192, 192); // Cinza Escuro



            // Ajuste o tamanho e a cor das células
            Cell cells05 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(3) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda             
                .SetBackgroundColor(cellColor2)
                //.SetMargin(3)
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("3.56"));

            Cell cells06 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(3) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetBackgroundColor(cellColor2)
               .SetFont(fonts)
                .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("5.33"));

            Cell cells07 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(3) // Ajuste o preenchimento da célula
               .SetBackgroundColor(cellColor2)
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("7.11"));

            Cell cells08 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(3) // Ajuste o preenchimento da célula
               .SetBackgroundColor(cellColor2)
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("10.67"));



            // Adicione as células à linha
            tables03.AddCell(cells05);
            tables03.AddCell(cells06);
            tables03.AddCell(cells07);
            tables03.AddCell(cells08);


            tables03.SetFixedPosition(2, 325, 296, 120);

            tempDocument.Add(tables03);


            Paragraph para4 = new Paragraph("Volume de exposição refrigerada (m3)")
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 285, 276);
            tempDocument.Add(para4);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables04 = new Table(4);
         

            // Ajuste o tamanho e a cor das células
            Cell cells09 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(5) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda             
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("282"));

            Cell cells10 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda             
               .SetFont(fonts)
                .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("1173"));

            Cell cells11 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula               
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("1564"));

            Cell cells12 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(5) // Ajuste o preenchimento da célula               
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("2346"));



            // Adicione as células à linha
            tables04.AddCell(cells09);
            tables04.AddCell(cells10);
            tables04.AddCell(cells11);
            tables04.AddCell(cells12);


            tables04.SetFixedPosition(2, 325, 280, 120);

            tempDocument.Add(tables04);


            Paragraph para5 = new Paragraph("Comprimento total com laterais (mm)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(20)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 266, 276);
            tempDocument.Add(para5);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables05 = new Table(4);          



            // Ajuste o tamanho e a cor das células
            Cell cells011 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(3) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda             
                .SetBackgroundColor(cellColor2)
                //.SetMargin(3)
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("3.56"));

            Cell cell12 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(3) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetBackgroundColor(cellColor2)
               .SetFont(fonts)
                .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("5.33"));

            Cell cells13 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(3) // Ajuste o preenchimento da célula
               .SetBackgroundColor(cellColor2)
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("7.11"));

            Cell cells14 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(3) // Ajuste o preenchimento da célula
               .SetBackgroundColor(cellColor2)
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("10.67"));



            // Adicione as células à linha
            tables05.AddCell(cells011);
            tables05.AddCell(cell12);
            tables05.AddCell(cells13);
            tables05.AddCell(cells14);


            tables05.SetFixedPosition(2, 325, 265, 120);

            tempDocument.Add(tables05);



            Paragraph para6 = new Paragraph("Tensão/Frequência")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40)
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 242, 276);
            tempDocument.Add(para6);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables06 = new Table(4);



            // Ajuste o tamanho e a cor das células
            Cell cells015 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(112) // Ajuste a largura da célula
                .SetPadding(3) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda             
                .SetBackgroundColor(cellColor2)
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("230V / 50Hz "));


            // Adicione as células à linha
            tables06.AddCell(cells015);
           

            tables06.SetFixedPosition(2, 325, 240, 200);

            tempDocument.Add(tables06);



            Paragraph para7 = new Paragraph("Potência nominal (W)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 228, 276);
            tempDocument.Add(para7);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables07 = new Table(4);



            // Ajuste o tamanho e a cor das células
            Cell cells016 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(4) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda      
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("370"));

            Cell cell17 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(4) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
                .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("440"));

            Cell cells18 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(4) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("710"));

            Cell cells19 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(4) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("740"));



            // Adicione as células à linha
            tables07.AddCell(cells016);
            tables07.AddCell(cell17);
            tables07.AddCell(cells18);
            tables07.AddCell(cells19);


            tables07.SetFixedPosition(2, 325, 225, 120);
             
            tempDocument.Add(tables07);



            Paragraph para8 = new Paragraph("Corrente nominal (A)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 214, 276);
            tempDocument.Add(para8);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables08 = new Table(4);



            // Ajuste o tamanho e a cor das células
            Cell cells020 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(2) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda      
                .SetBackgroundColor(cellColor2)
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("1.7"));

            Cell cell21 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("2.1"));

            Cell cells22 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3.2"));

            Cell cells23 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3.7"));



            // Adicione as células à linha
            tables08.AddCell(cells020);
            tables08.AddCell(cell21);
            tables08.AddCell(cells22);
            tables08.AddCell(cells23);


            tables08.SetFixedPosition(2, 325, 214, 120);

            tempDocument.Add(tables08);



            Paragraph para9 = new Paragraph("Iluminação (W)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 197, 276);
            tempDocument.Add(para9);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables09 = new Table(4);



            // Ajuste o tamanho e a cor das células
            Cell cells024 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(2) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda                   
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("1 x 19"));

            Cell cell25 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("1 x 22"));

            Cell cells26 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("2 x 19"));

            Cell cells27 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3 x 19"));



            // Adicione as células à linha
            tables09.AddCell(cells024);
            tables09.AddCell(cell25);
            tables09.AddCell(cells26);
            tables09.AddCell(cells27);


            tables09.SetFixedPosition(2, 325, 197, 120);

            tempDocument.Add(tables09);



            Paragraph para10 = new Paragraph("Consumo anual de energia (KWh/a)*")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 180, 276);
            tempDocument.Add(para10);


            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables10 = new Table(4);



            // Ajuste o tamanho e a cor das células
            Cell cells029 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(2) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda                   
                .SetBackgroundColor(cellColor2)
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("2 874"));

            Cell cell30 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetBackgroundColor(cellColor2)
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3 553"));

            Cell cells31 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("5 084"));

            Cell cells32 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("5 794"));



            // Adicione as células à linha
            tables10.AddCell(cells029);
            tables10.AddCell(cell30);
            tables10.AddCell(cells31);
            tables10.AddCell(cells32);


            tables10.SetFixedPosition(2, 325, 180, 120);

            tempDocument.Add(tables10);


            Paragraph para11 = new Paragraph("Classe eficiência energética")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 166, 276);
            tempDocument.Add(para11);


            Table tables012 = new Table(4);

            // Crie a imagem
            ImageData imageData11 = ImageDataFactory.Create("https://mm.mafirol.info/Categories/Subfamilies/EnergyEfficiency/20220107172351808_f900b70d-817b-43aa-8b82-d9bb76a8606e.jpg");
            Image image11 = new Image(imageData11);
            image11.ScaleToFit(30, 30); // Ajuste o tamanho da imagem conforme necessário

            // Ajuste o tamanho e a cor das células
            Cell cellsImg = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(112) // Ajuste a largura da célula
                .SetPadding(3) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda
                .Add(image11); // Adicione a imagem à célula

            // Adicione as células à linha
            tables012.AddCell(cellsImg);

            tables012.SetFixedPosition(2, 322, 152, 276);

            tempDocument.Add(tables012);



            Paragraph para12 = new Paragraph("Resistência evaporação condensados (opcional)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                 .SetFontSize(9) 
                 .SetMarginLeft(40) 
                 .SetMarginBottom(5) 
                 .SetFont(font4)
           .SetFixedPosition(2, 20, 135, 276);
            tempDocument.Add(para12);

            Paragraph paraDetails12 = new Paragraph("*Para classe temperatura M1 (-1, +5ºC)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.LEFT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                 .SetFontSize(6)
                 .SetMarginLeft(40)
                 .SetMarginBottom(5)
                 .SetFont(font4)
           .SetFixedPosition(2, 325, 125, 180);
            tempDocument.Add(paraDetails12);

            //############# TABELA AO LADO DE CADA LABEL

            // Crie uma nova tabela com 4 colunas
            Table tables11 = new Table(4);



            // Ajuste o tamanho e a cor das células
            Cell cells037 = new Cell(1, 1)
                .SetHeight(9) // Ajuste a altura da célula
                .SetWidth(30) // Ajuste a largura da célula
                .SetPadding(2) // Ajuste o preenchimento da célula
                .SetBorder(Border.NO_BORDER) // Remova a borda                   
                .SetBackgroundColor(cellColor2)
                .SetFont(fonts)
                .SetFontSize(6)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(fontColor02)
                .Add(new Paragraph("1 x 270"));

            Cell cell38 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetBackgroundColor(cellColor2)
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("2 x 270"));

            Cell cells39 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("2 x 270"));

            Cell cells40 = new Cell(1, 1)
               .SetHeight(9) // Ajuste a altura da célula
               .SetWidth(30) // Ajuste a largura da célula
               .SetPadding(2) // Ajuste o preenchimento da célula
               .SetMargin(10)
               .SetBackgroundColor(cellColor2)
               .SetBorder(Border.NO_BORDER) // Remova a borda
               .SetFont(fonts)
               .SetFontSize(6)
               .SetFontColor(fontColor02)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("3 x 270"));



            // Adicione as células à linha
            tables11.AddCell(cells037);
            tables11.AddCell(cell38);
            tables11.AddCell(cells39);
            tables11.AddCell(cells40);


            tables11.SetFixedPosition(2, 325, 135, 120);

            tempDocument.Add(tables11);





            //##################################################################### ------------------------- ##################################################################################
            //-------------------------------- FOOTER ------------------------------------

            PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            Paragraph TitleFooter = new Paragraph("Condições de operação recomendadas:")
             .SetFontSize(7)
             .SetFont(fontBold)
             .SetMarginLeft(38)
             .SetHorizontalAlignment(HorizontalAlignment.CENTER)
             .SetWidth(UnitValue.CreatePercentValue(50))
             .SetRelativePosition(60, 130, 40, 100)
             //.SetFontFamily() .SetTextAlignment(TextAlignment.CENTER)
             .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(TitleFooter);

            Paragraph mafirolCom = new Paragraph(".mafirol.com")
            .SetFontSize(8)
            //.SetFont(fontBold)
            .SetMarginLeft(38)
            .SetHorizontalAlignment(HorizontalAlignment.CENTER)
            .SetWidth(UnitValue.CreatePercentValue(50))
            .SetRelativePosition(158, 192, 40, 100)
            //.SetFontFamily() .SetTextAlignment(TextAlignment.CENTER)
            .SetFontColor(ColorConstants.GRAY);
            tempDocument.Add(mafirolCom);

            Paragraph paragraphFooter3 = new Paragraph("Este equipamento foi projetado para operar" +
                " num ambiente interior onde a temperatura e a humidade relativa não exceda 25ºC e 60%Hr (classe climática 3).\r\nNão instalar sob a luz solar direta ou sobre influência de corrente de ar.")
               .SetFontSize(7)
               //.SetMarginLeft(10)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER)
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFixedPosition(2, -150, 70, 900)
               .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraphFooter3);


            Paragraph paragraphFooter2 = new Paragraph("Especificações sujeitas a alterações sem aviso prévio. tempDocumento não contratual.")
               .SetFontSize(7)
               .SetMarginLeft(38)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER) //----------------------------------------------------------------------------------------------
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetFixedPosition(2, 175, 50, 900)
               .SetFontColor(ColorConstants.BLACK);
            tempDocument.Add(paragraphFooter2);


            //##################################### IMAGEM 1 FOOTERS ############################################################

            string imagePath02 = "https://mm.mafirol.info/assinaturas/Mafirol_mir.png";
            ImageData imageDatar02 = ImageDataFactory.Create(imagePath02);
            Image img02 = new Image(imageDatar02);

            img02.ScaleAbsolute(40, 40);  // ajuste esses valores conforme necessário
            img02.SetFixedPosition(2, 240, 2, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer02 = new Paragraph().Add(img02).SetTextAlignment(TextAlignment.CENTER);
            tempDocument.Add(footer02);


            //##################################### IMAGEM 2 FOOTERS ############################################################

            string imagePath03 = "https://mm.mafirol.info/assinaturas/WWW.png";
            ImageData imageDatar03 = ImageDataFactory.Create(imagePath03);
            Image img03 = new Image(imageDatar03);

            img03.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            img03.SetFixedPosition(2, 290, 2, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer03 = new Paragraph().Add(img03).SetTextAlignment(TextAlignment.CENTER);
            tempDocument.Add(footer03);

            //####################################### FIM FOOTER ####################################

            // Feche o documento intermediário (isto vai 'liberar' o MemoryStream)
            tempDocument.Close();

            // Crie o documento final
            MemoryStream finalMemoryStream = new MemoryStream();
            PdfWriter finalWriter = new PdfWriter(finalMemoryStream);
            PdfDocument finalPdf = new PdfDocument(finalWriter);
            Document finalDocument = new Document(finalPdf);

            // Crie um novo PdfReader a partir do MemoryStream intermediário
            PdfReader reader = new PdfReader(new MemoryStream(tempMemoryStream.ToArray()));

            // Crie um novo PdfDocument a partir do PdfReader
            PdfDocument sourceDocument = new PdfDocument(reader);

            // Copie as páginas do documento intermediário para o documento final
            sourceDocument.CopyPagesTo(1, sourceDocument.GetNumberOfPages(), finalPdf);

            // Feche o documento final
            finalDocument.Close();

            // Retorne o MemoryStream final
            return finalMemoryStream;



            //Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true }); //Abre o arquivo após ser criado
        }


    }


}
