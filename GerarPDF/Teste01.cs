﻿using iText.Kernel.Pdf;
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

namespace GerarPDF
{
    public class PDFModel
    {
        public string Language { get; set; }
        public string Param01 { get; set; }
        public string Param02 { get; set; }
        public string Param03 { get; set; }
        public string Param04 { get; set; }
        public string Param05 { get; set; }
        public string Param06 { get; set; }
        public string Param07 { get; set; }
        public string Param08 { get; set; }
        public string Param09 { get; set; }
        public string Param10 { get; set; }
        public string Param11 { get; set; }
        public string Param12 { get; set; }
        public string Param13 { get; set; }
        public string Param14 { get; set; }
        public string Param15 { get; set; }
        public string Param16 { get; set; }
        public string Param17 { get; set; }
        public string Param18 { get; set; }
        public string Param19 { get; set; }
        public string Param20 { get; set; }
        public string Param21 { get; set; }
        public string Param22 { get; set; }
        public string Param23 { get; set; }
    }
  

    public class Teste01
    {

        public void Teste()
        {

            //string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "teste.pdf");
            var name = Guid.NewGuid().ToString();
            var pdfPath = $@"C:\\pdf\{name}_teste.pdf";


            PdfWriter writer = new PdfWriter(pdfPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, PageSize.A4);
            document.SetMargins(5, 20, 0, 20);

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
            document.Add(header);

            Paragraph subHeader1 = new Paragraph("MURAL REFRIGERADO COM PORTAS")
               .SetRelativePosition(5, 0, 40, 62)
               .SetMarginTop(0)
               .SetPaddingTop(0)
               .SetMarginBottom(0)
               .SetPaddingBottom(0)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFont(font4)
               .SetFontSize(11);
            document.Add(subHeader1);



            Paragraph subHeader2 = new Paragraph("CARNE | LÁCTEOS | FRUTA E VEGETAIS")
               .SetRelativePosition(5, 0, 30, 65)
               .SetMarginTop(0)
               .SetPaddingTop(0)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFontColor(customColor3)
               .SetFont(font1)
               .SetFontSize(12);
            document.Add(subHeader2);


            Div div1 = new Div();
            div1.SetWidth(UnitValue.CreatePercentValue(100));  // 50% da largura total
            div1.SetBorderBottom(new SolidBorder(0.4f));
            div1.SetMarginBottom(5);  // espaço abaixo da linha
            div1.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            div1.SetRelativePosition(5, 0, 30, 69);

            document.Add(div1);

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
            // Defina a posição da imagem (x, y) no documento
            images.SetFixedPosition(230, 400);

            document.Add(images);

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
            document.Add(body00);

            //-------------- linha separadora--
            Div div00 = new Div();
            div00.SetWidth(UnitValue.CreatePercentValue(43));
            div00.SetBorderBottom(new SolidBorder(0.5f));
            div00.SetMarginBottom(5);
            div00.SetFixedPosition(350, 350, 200);
            div00.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            document.Add(div00);
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

            // Posiciona a tabela no documento
            table.SetFixedPosition(350, 200, 200);
            document.Add(table);


            //##################################################### BLOCO 02 ABAIXO DA IMAGEM PRINCIPAL, DIVISÃO E TEXTO ########################################################################

            Paragraph body02 = new Paragraph("COR Interior STANDARD".ToUpper())
                .SetWidth(UnitValue.CreatePercentValue(w))
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetFixedPosition(350, 165, 200) // Usando SetFixedPosition
                .SetFont(font1)
                .SetFontColor(customColor1);
            document.Add(body02);

            //-------------- linha separadora--
            Div div001 = new Div();
            div001.SetWidth(UnitValue.CreatePercentValue(43));
            div001.SetBorderBottom(new SolidBorder(0.5f));
            div001.SetMarginBottom(5);
            div001.SetFixedPosition(350, 165, 200);
            div001.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            document.Add(div001);
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

            // Posiciona a tabela no documento
            table02.SetFixedPosition(350, 65, 200);
            document.Add(table02);

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
            document.Add(body);

            //-------------- linha separadora--

            Div div = new Div();
            div.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div.SetBorderBottom(new SolidBorder(0.5f));
            div.SetMarginBottom(5);  // espaço abaixo da linha
            div.SetMarginLeft(0);
            div.SetRelativePosition(1, -50, 30, 5);
            div.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            document.Add(div);
            //--------


            Paragraph paragraph1 = new Paragraph("Lorem Ipsum is simply dummy text of " +
                "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,Lorem Ipsum is simply dummy text of " +
                "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
                .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph1);



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
            document.Add(body2);

            //-------------- linha separadora--
            Div div01 = new Div();
            div01.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div01.SetBorderBottom(new SolidBorder(0.5f));
            div01.SetMarginBottom(5);  // espaço abaixo da linha
            div01.SetMarginLeft(0);
            div01.SetRelativePosition(1, -50, 30, 5);
            div01.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            document.Add(div01);
            //--------


            Paragraph paragraph2 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph2);

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
            document.Add(body3);

            //-------------- linha separadora--
            Div div03 = new Div();
            div03.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div03.SetBorderBottom(new SolidBorder(0.5f));
            div03.SetMarginBottom(5);  // espaço abaixo da linha
            div03.SetMarginLeft(0);
            div03.SetRelativePosition(1, -50, 30, 5);
            div03.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            document.Add(div03);
            //--------

            Paragraph paragraph3 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph3);

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
            document.Add(body4);

            //-------------- linha separadora--
            Div div04 = new Div();
            div04.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div04.SetBorderBottom(new SolidBorder(0.5f));
            div04.SetMarginBottom(5);  // espaço abaixo da linha
            div04.SetMarginLeft(0);
            div04.SetRelativePosition(1, -50, 30, 5);
            div04.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            document.Add(div04);
            //--------

            Paragraph paragraph4 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem y. Lorem Ipsum has been the industry's standard dummy text ever since " +
               "Ipsum has been the industry's standard dummy text ever since the 1500s, ")
                .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph4);

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
            document.Add(body5);

            //-------------- linha separadora--
            Div div05 = new Div();
            div05.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div05.SetBorderBottom(new SolidBorder(0.5f));
            div05.SetMarginBottom(5);  // espaço abaixo da linha
            div05.SetMarginLeft(0);
            div05.SetRelativePosition(1, -50, 30, 5);
            div05.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            document.Add(div05);
            //--------


            Paragraph paragraph5 = new Paragraph("Lorem Ipsum is simply dummy text of " +
               "the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, ")
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph5);



            //-------------------------------- FOOTER ------------------------------------


            Div divfooter = new Div();
            divfooter.SetWidth(UnitValue.CreatePercentValue(100));  // 50% da largura total
            divfooter.SetBorderBottom(new SolidBorder(0.4f));
            divfooter.SetMarginBottom(5);  // espaço abaixo da linha
            divfooter.SetHorizontalAlignment(HorizontalAlignment.LEFT);  // Centraliza a Div
            divfooter.SetRelativePosition(5, 70, 30, 69);

            //document.Add(divfooter);

            Paragraph paragraphFooter = new Paragraph("Especificações sujeitas a alterações sem aviso prévio. Documento não contratual.")
               .SetFontSize(6)
               .SetMarginLeft(38)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER)
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetRelativePosition(1, 65, 30, 90)
               .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraphFooter);


            Paragraph mafirolCom0 = new Paragraph(".mafirol.com")
            .SetFontSize(8)
            //.SetFont(fontBold)
            .SetMarginLeft(38)
            .SetHorizontalAlignment(HorizontalAlignment.CENTER)
            .SetWidth(UnitValue.CreatePercentValue(50))
            .SetRelativePosition(158, 77, 40, 100)
            //.SetFontFamily() .SetTextAlignment(TextAlignment.CENTER)
            .SetFontColor(ColorConstants.GRAY);
            document.Add(mafirolCom0);
            //##################################### IMAGEM 1 FOOTERS ############################################################


            string imagePath = "https://mm.mafirol.info/assinaturas/Mafirol_mir.png";
            ImageData imageData = ImageDataFactory.Create(imagePath);
            Image img = new Image(imageData);

            img.ScaleAbsolute(130, 120);  // ajuste esses valores conforme necessário
            img.SetFixedPosition(1, 240, 2, 380);

            //img03.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            //img03.SetFixedPosition(2, 290, 2, 1200);

            Paragraph footer = new Paragraph().Add(img).SetTextAlignment(TextAlignment.CENTER);
            document.Add(footer);



            //##################################### IMAGEM 2 FOOTERS ############################################################

            string imagePath08 = "https://mm.mafirol.info/assinaturas/WWW.png";
            ImageData imageDatar08 = ImageDataFactory.Create(imagePath08);
            Image img08 = new Image(imageDatar08);

            img08.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            img08.SetFixedPosition(1, 290, 2, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer08 = new Paragraph().Add(img08).SetTextAlignment(TextAlignment.CENTER);
            document.Add(footer08);



            //################################################################### SEGUNDA PÁGINA #################################################################################################

            // Adiciona nova página
            document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

            document.Add(header);
            document.Add(subHeader1);
            document.Add(subHeader2);
            document.Add(div1);

            //#####################################################################  ---------  BODY --------   ###################################################################################

            // Cria um objeto de imagem
            string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230524135250806_92d9f97f-c500-483d-a744-f5a757ef9295.png"; // Altere para a URL da imagem ou caminho local
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230309113554775_553e1c22-3eca-4a47-84ee-d5782b80c048.png";
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230508134640521_0d9ae880-59f2-4fe5-ab8c-ce9193f9bf0d.png";
            ImageData imageDatar = ImageDataFactory.Create(imagePathr);
            Image imager = new Image(imageDatar);

            // Você pode alterar a escala da imagem de acordo com suas necessidades
            imager.ScaleAbsolute(490, 390);

            // Defina a posição da imagem (x, y) no documento         
            imager.SetRelativePosition(40, -70, 40, 800);
            document.Add(imager);

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
            document.Add(body6);

            //-------------- linha separadora--
            Div div06 = new Div();
            div06.SetWidth(UnitValue.CreatePercentValue(43));  // 50% da largura total
            div06.SetBorderBottom(new SolidBorder(0.5f));
            div06.SetMarginBottom(5);  // espaço abaixo da linha
            div06.SetMarginLeft(0);
            div06.SetRelativePosition(1, -114, 30, 5);
            div06.SetHorizontalAlignment(HorizontalAlignment.CENTER);  // Centraliza a Div
            document.Add(div06);
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
            document.Add(para1);

            // Crie uma nova tabela com 4 colunas
            Table tables01 = new Table(4);

            // Adicione as células à linha
            tables01.AddCell(new Cell().Add(new Paragraph("Cell 1")));
            tables01.AddCell(new Cell().Add(new Paragraph("Cell 2")));
            tables01.AddCell(new Cell().Add(new Paragraph("Cell 3")));
            tables01.AddCell(new Cell().Add(new Paragraph("Cell 4")));

            tables01.SetFixedPosition(2, 350, 330, 170);

            // Adicione a tabela ao documento
            document.Add(tables01);


            Paragraph para2 = new Paragraph("Área total de exposição (TDA) (m2)")
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 315, 276);
            document.Add(para2);

            Paragraph para3 = new Paragraph("Superfície de refrigerada (m 2)")
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 300, 276);
            document.Add(para3);

            Paragraph para4 = new Paragraph("Volume de exposição refrigerada (m3)")
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 285, 276);
            document.Add(para4);

            Paragraph para5 = new Paragraph("Comprimento total com laterais (mm)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(20)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 270, 276);
            document.Add(para5);

            Paragraph para6 = new Paragraph("Tensão/Frequência")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40)
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 250, 276);
            document.Add(para6);

            Paragraph para7 = new Paragraph("Potência nominal (W)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 235, 276);
            document.Add(para7);

            Paragraph para8 = new Paragraph("Corrente nominal (A)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 220, 276);
            document.Add(para8);

            Paragraph para9 = new Paragraph("Iluminação (W)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 205, 276);
            document.Add(para9);

            Paragraph para10 = new Paragraph("Consumo anual de energia (KWh/a)*")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 190, 276);
            document.Add(para10);

            Paragraph para11 = new Paragraph("Classe eficiência energética")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 175, 276);
            document.Add(para11);

            Paragraph para12 = new Paragraph("Resistência evaporação condensados (opcional)")
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                 .SetFontSize(9) 
                 .SetMarginLeft(40) 
                 .SetMarginBottom(5) 
                 .SetFont(font4)
           .SetFixedPosition(2, 20, 155, 276);
            document.Add(para12);

            




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
            document.Add(TitleFooter);

            Paragraph mafirolCom = new Paragraph(".mafirol.com")
            .SetFontSize(8)
            //.SetFont(fontBold)
            .SetMarginLeft(38)
            .SetHorizontalAlignment(HorizontalAlignment.CENTER)
            .SetWidth(UnitValue.CreatePercentValue(50))
            .SetRelativePosition(158, 192, 40, 100)
            //.SetFontFamily() .SetTextAlignment(TextAlignment.CENTER)
            .SetFontColor(ColorConstants.GRAY);
            document.Add(mafirolCom);

            Paragraph paragraphFooter3 = new Paragraph("Este equipamento foi projetado para operar" +
                " num ambiente interior onde a temperatura e a humidade relativa não exceda 25ºC e 60%Hr (classe climática 3).\r\nNão instalar sob a luz solar direta ou sobre influência de corrente de ar.")
               .SetFontSize(7)
               //.SetMarginLeft(10)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER)
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFixedPosition(2, -150, 70, 900)
               .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraphFooter3);


            Paragraph paragraphFooter2 = new Paragraph("Especificações sujeitas a alterações sem aviso prévio. Documento não contratual.")
               .SetFontSize(7)
               .SetMarginLeft(38)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER) //----------------------------------------------------------------------------------------------
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetFixedPosition(2, 175, 50, 900)
               .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraphFooter2);


            //##################################### IMAGEM 1 FOOTERS ############################################################

            string imagePath02 = "https://mm.mafirol.info/assinaturas/Mafirol_mir.png";
            ImageData imageDatar02 = ImageDataFactory.Create(imagePath02);
            Image img02 = new Image(imageDatar02);

            img02.ScaleAbsolute(40, 40);  // ajuste esses valores conforme necessário
            img02.SetFixedPosition(2, 240, 2, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer02 = new Paragraph().Add(img02).SetTextAlignment(TextAlignment.CENTER);
            document.Add(footer02);


            //##################################### IMAGEM 2 FOOTERS ############################################################

            string imagePath03 = "https://mm.mafirol.info/assinaturas/WWW.png";
            ImageData imageDatar03 = ImageDataFactory.Create(imagePath03);
            Image img03 = new Image(imageDatar03);

            img03.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            img03.SetFixedPosition(2, 290, 2, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer03 = new Paragraph().Add(img03).SetTextAlignment(TextAlignment.CENTER);
            document.Add(footer03);

            document.Close();

            Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
        }


    }


}
