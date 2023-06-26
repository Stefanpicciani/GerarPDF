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

namespace GerarPDF
{

    public class RalImg
    {
        public int Id { get; set; }
        public string? Url { get; set; }
    }

    public class PDFModel
    {
        // Page One
        public string? Language { get; set; } = "PT";
        public string? Title { get; set; } = "ultar";
        public string? Subtitle { get; set; } = "MURAL refrigerado COM PORTAS";
        public string? SubtitleText { get; set; } = "CARNE | LÁCTEOS | FRUTA E VEGETAIS";

        public string? Title1 { get; set; } = "DESCRIÇÃO GERAL";
        public string? Paragraph1 { get; set; } = "Lorem Ipsum is simply dummy text of the printing and\r\ntypesetting industry. Lorem Ipsum has been the\r\nindustry's standard dummy text ever since the\r\n1500s,Lorem Ipsum is simply dummy text of the\r\nprinting and typesetting industry. Lorem Ipsum has\r\nbeen the industry's standard dummy text ever since the\r\n1500s,";

        public string? Title2 { get; set; } = "SISTEMA DE REFRIGERAÇÃO";
        public string? Paragraph2 { get; set; } = "Lorem Ipsum is simply dummy text of the printing and\r\ntypesetting industry. Lorem Ipsum has been the\r\nindustry's standard dummy text ever since the 1500s,";

        public string? Title3 { get; set; } = "SISTEMA ELÉTRICO, COMANDO E REGULAÇÃO";
        public string? Paragraph3 { get; set; } = "Lorem Ipsum is simply dummy text of the printing and\r\ntypesetting industry. Lorem Ipsum has been the\r\nindustry's standard dummy text ever since the 1500s";

        public string? Title4 { get; set; } = "COMPLEMENTOS";
        public string? Paragraph4 { get; set; } = "Lorem Ipsum is simply dummy text of the printing and\r\ntypesetting industry. Lorem y. Lorem Ipsum has been\r\nthe industry's standard dummy text ever since Ipsum\r\nhas been the industry's standard dummy text ever\r\nsince the 1500s,";

        public string? Title5 { get; set; } = "OPÇÕES";
        public string? Paragraph5 { get; set; } = "Lorem Ipsum is simply dummy text of the printing and\r\ntypesetting industry. Lorem Ipsum has been the\r\nindustry's standard dummy text ever since the 1500s,";

        public string? ExteriorColor { get; set; } = "COR EXTERIOR STANDARD";
        public string? InteriorColor { get; set; } = "COR INTERIOR STANDARD";

        public List<string> ListColor1 { get; set; } = new List<string> {
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

        public List<string> ListColor2 { get; set; } = new List<string> {
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

        public string? UrlImgMain { get; set; } = "https://mm.mafirol.info/Categories/Subfamilies/20230607152016175_ef9729b0-fd42-4173-9e2d-0ce8bd29ac4e.png";

        //Footer 1
        public string? TextFooter1 { get; set; } = "Especificações sujeitas a alterações sem aviso prévio. Documento não contratual.";


        //Page Two
        public string? UrlImgCut { get; set; } = "https://mm.mafirol.info/Categories/Variants/Profile/20230524135250806_92d9f97f-c500-483d-a744-f5a757ef9295.png";
        public string? TechnicalInformation { get; set; } = "INFORMAÇÃO TÉCNICA";

        public string? Col1Model { get; set; } = "1250";
        public string? Col2Model { get; set; } = "1875";
        public string? Col3Model { get; set; } = "2500";
        public string? Col4Model { get; set; } = "3750";

        public string? Param1 { get; set; } = "Área total de exposição (TDA) (m2)";
        public string? Col1Param1 { get; set; } = "1.88";
        public string? Col2Param1 { get; set; } = "2.82";
        public string? Col3Param1 { get; set; } = "3.76";
        public string? Col4Param1 { get; set; } = "5.64";

        public string? Param2 { get; set; } = "Superfície de refrigerada (m 2)";
        public string? Col1Param2 { get; set; } = "3.56";
        public string? Col2Param2 { get; set; } = "5.33";
        public string? Col3Param2 { get; set; } = "7.11";
        public string? Col4Param2 { get; set; } = "10.67";

        public string? Param3 { get; set; } = "Volume de exposição refrigerada (m3)";
        public string? Col1Param3 { get; set; } = "282";
        public string? Col2Param3 { get; set; } = "1173";
        public string? Col3Param3 { get; set; } = "1564";
        public string? Col4Param3 { get; set; } = "2346";

        public string? Param4 { get; set; } = "Comprimento total com laterais (mm)";
        public string? Col1Param4 { get; set; } = "3.56";
        public string? Col2Param4 { get; set; } = "5.33";
        public string? Col3Param4 { get; set; } = "7.11";
        public string? Col4Param4 { get; set; } = "10.67";

        public string? Param5 { get; set; } = "Tensão/Frequência";
        public string? ColParam5 { get; set; } = "230V / 50Hz";

        public string? Param6 { get; set; } = "Potência nominal (W)";
        public string? Col1Param6 { get; set; } = "370";
        public string? Col2Param6 { get; set; } = "440";
        public string? Col3Param6 { get; set; } = "710";
        public string? Col4Param6 { get; set; } = "740";

        public string? Param7 { get; set; } = "Corrente nominal (A)";
        public string? Col1Param7 { get; set; } = "1.7";
        public string? Col2Param7 { get; set; } = "2.1";
        public string? Col3Param7 { get; set; } = "3.2";
        public string? Col4Param7 { get; set; } = "3.7";

        public string? Param8 { get; set; } = "Iluminação (W)";
        public string? Col1Param8 { get; set; } = "1 x 19";
        public string? Col2Param8 { get; set; } = "1 x 22";
        public string? Col3Param8 { get; set; } = "2 x 19";
        public string? Col4Param8 { get; set; } = "3 x 19";

        public string? Param9 { get; set; } = "Consumo anual de energia (KWh/a)*";
        public string? Col1Param9 { get; set; } = "2 874";
        public string? Col2Param9 { get; set; } = "3 553";
        public string? Col3Param9 { get; set; } = "5 084";
        public string? Col4Param9 { get; set; } = "5 794";

        public string? Param10 { get; set; } = "Classe eficiência energética";
        public string? UrlImageEfficientEnergyParam10 { get; set; } = "https://mm.mafirol.info/Categories/Subfamilies/EnergyEfficiency/20220107172351808_f900b70d-817b-43aa-8b82-d9bb76a8606e.jpg";

        public string? Param11 { get; set; } = "Resistência evaporação condensados (opcional)";
        public string? Col1Param11 { get; set; } = "1 x 270";
        public string? Col2Param11 { get; set; } = "2 x 270";
        public string? Col3Param11 { get; set; } = "2 x 270";
        public string? Col4Param11 { get; set; } = "3 x 270";
        public string? ParamTextUnder { get; set; } = "*Para classe temperatura M1 (-1, +5ºC)";

        //Footer 2
        public string? TitleFooter2 { get; set; } = "Condições de operação recomendadas:";
        public string? SubTitleFooter2 { get; set; } = "Este equipamento foi projetado para operar num ambiente interior onde a temperatura e a humidade relativa não exceda 25ºC e 60%Hr (classe climática 3).\r\nNão instalar sob a luz solar direta ou sobre influência de corrente de ar.";
        public string? TextFooter2 { get; set; } = "Especificações sujeitas a alterações sem aviso prévio. Documento não contratual.";
    }
  

    public class Teste01
    {

        public void Teste()
        {
            PDFModel genpdf = new PDFModel();
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

            Paragraph header = new Paragraph(genpdf.Title.ToUpper())
                .SetRelativePosition(1, 0, 40, 14)
                .SetFontColor(customColor)
                .SetFont(font)
                .SetFontSize(75);
            document.Add(header);

            Paragraph subHeader1 = new Paragraph(genpdf.Subtitle.ToUpper())
               .SetRelativePosition(5, 0, 40, 62)
               .SetMarginTop(0)
               .SetPaddingTop(0)
               .SetMarginBottom(0)
               .SetPaddingBottom(0)
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFont(font4)
               .SetFontSize(11);
            document.Add(subHeader1);



            Paragraph subHeader2 = new Paragraph(genpdf.SubtitleText.ToUpper())
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
            //string imagePaths = "https://mm.mafirol.info/Categories/Subfamilies/20230607152016175_ef9729b0-fd42-4173-9e2d-0ce8bd29ac4e.png"; // Altere para a URL da imagem ou caminho local
            ImageData imageDatas = ImageDataFactory.Create(genpdf.UrlImgMain);
            Image images = new Image(imageDatas);

            // Você pode alterar a escala da imagem de acordo com suas necessidades
            images.ScaleAbsolute(410, 310);
            // Defina a posição da imagem (x, y) no documento
            images.SetFixedPosition(230, 400);

            document.Add(images);

            //##################################################### BLOCO ABAIXO DA IMAGEM PRINCIPAL, DIVISÃO E TEXTO ########################################################################

            Paragraph body00 = new Paragraph(genpdf.ExteriorColor.ToUpper())
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

            //// Lista de URLs das imagens
            //List<string> imageUrlsExt = new List<string>
            //{
            //    "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1012.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1013.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1021.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1037.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2001.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2002.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2008.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3000.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3016.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5000.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5015.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5023.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5010.png",  
             
                                             
            //    // ...
            //};

            int count = 0;

            foreach (string url in genpdf.ListColor1)
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

            Paragraph body02 = new Paragraph(genpdf.InteriorColor.ToUpper())
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

            //// Lista de URLs das imagens
            //List<string> imageUrlsInt = new List<string>
            //{
            //"\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1012.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1013.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1021.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\1037.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2001.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2002.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\2008.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3000.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\3016.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5000.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5015.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5023.png",
            //      "\\\\mafserver\\DARQ\\Marketing\\MATERIAL DE TRABALHO\\RAL\\5010.png",                
                                        
            //    // ...
            //};

            int counter = 0;

            foreach (string url in genpdf.ListColor2)
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

            Paragraph body = new Paragraph(genpdf.Title1.ToUpper())
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


            Paragraph paragraph1 = new Paragraph(genpdf.Paragraph1)
                .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph1);



            //##################################################### BLOCO 2 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body2 = new Paragraph(genpdf.Title2.ToUpper())
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


            Paragraph paragraph2 = new Paragraph(genpdf.Paragraph2)
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph2);

            //##################################################### BLOCO 3 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body3 = new Paragraph(genpdf.Title3.ToUpper())
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

            Paragraph paragraph3 = new Paragraph(genpdf.Paragraph3)
               .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph3);

            //##################################################### BLOCO 4 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body4 = new Paragraph(genpdf.Title4.ToUpper())
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

            Paragraph paragraph4 = new Paragraph(genpdf.Paragraph4)
                .SetFontSize(9)
                .SetWidth(UnitValue.CreatePercentValue(40))
                .SetRelativePosition(1, -50, 30, 60)
                 .SetMarginBottom(10)
                .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraph4);

            //##################################################### BLOCO 5 DO PARÁGRAFO , DIVISÃO E TEXTO ########################################################################

            Paragraph body5 = new Paragraph(genpdf.Title5.ToUpper())
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


            Paragraph paragraph5 = new Paragraph(genpdf.Paragraph5)
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

            Paragraph paragraphFooter = new Paragraph(genpdf.TextFooter1)
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

            string currentDirectory = Environment.CurrentDirectory;
            string imagePath = System.IO.Path.Combine(currentDirectory, "Assets" ,"Images", "mafiroLogo.png");

            ////string imagePath = "https://mm.mafirol.info/assinaturas/Mafirol_mir.png";
            ImageData imageData = ImageDataFactory.Create(imagePath);
            Image img = new Image(imageData);

            img.ScaleAbsolute(130, 120);  // ajuste esses valores conforme necessário
            img.SetFixedPosition(1, 240, 2, 380);

            //img03.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            //img03.SetFixedPosition(2, 290, 2, 1200);

            Paragraph footer = new Paragraph().Add(img).SetTextAlignment(TextAlignment.CENTER);
            document.Add(footer);



            //##################################### IMAGEM 2 FOOTERS ############################################################

            string currencyDirectory = Environment.CurrentDirectory;
            string imagePath08 = System.IO.Path.Combine(currencyDirectory, "Assets","Images", "WWWlogo.png");

            //string imagePath08 = "https://mm.mafirol.info/assinaturas/WWW.png";
            ImageData imageDatar08 = ImageDataFactory.Create(imagePath08);
            Image img08 = new Image(imageDatar08);

            img08.ScaleAbsolute(150, 90);  // ajuste esses valores conforme necessário
            img08.SetFixedPosition(1, 290, 7, 1200);
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
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230524135250806_92d9f97f-c500-483d-a744-f5a757ef9295.png"; // Altere para a URL da imagem ou caminho local
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230309113554775_553e1c22-3eca-4a47-84ee-d5782b80c048.png";
            //string imagePathr = "https://mm.mafirol.info/Categories/Variants/Profile/20230508134640521_0d9ae880-59f2-4fe5-ab8c-ce9193f9bf0d.png";
            ImageData imageDatar = ImageDataFactory.Create(genpdf.UrlImgCut);
            Image imager = new Image(imageDatar);

            // Você pode alterar a escala da imagem de acordo com suas necessidades
            imager.ScaleAbsolute(490, 390);

            // Defina a posição da imagem (x, y) no documento         
            imager.SetRelativePosition(40, -70, 40, 800);
            document.Add(imager);

            Paragraph body6 = new Paragraph(genpdf.TechnicalInformation.ToUpper())
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

          

            var model = genpdf.Language.ToUpper();

            switch (model)
            {
                case "ES":
                    model = "MODELO";
                    break;
                case "PT":
                    model = "MODELO";
                    break;
                case "EN":
                    model = "MODEL";
                    break;
                case "FR":
                    model = "MODÈLE";
                    break;

                default:
                    break;
            }



            Paragraph para1 = new Paragraph(model)
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
                .Add(new Paragraph(genpdf.Col1Model)
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
                .Add(new Paragraph(genpdf.Col2Model));

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
                .Add(new Paragraph(genpdf.Col3Model));

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
               .Add(new Paragraph(genpdf.Col4Model));



            // Adicione as células à linha
            tables01.AddCell(cell1);
            tables01.AddCell(cell2);
            tables01.AddCell(cell3);
            tables01.AddCell(cell4);


            tables01.SetFixedPosition(2, 326, 330, 120);
           
            document.Add(tables01);

            //###### Label 2

            Paragraph para2 = new Paragraph(genpdf.Param1)
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 315, 276);
            document.Add(para2);

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
                .Add(new Paragraph(genpdf.Col1Param1)
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
               .Add(new Paragraph(genpdf.Col2Param1));

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
               .Add(new Paragraph(genpdf.Col3Param1));

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
               .Add(new Paragraph(genpdf.Col4Param1));



            // Adicione as células à linha
            tables02.AddCell(cells01);
            tables02.AddCell(cells02);
            tables02.AddCell(cells03);
            tables02.AddCell(cells04);


            tables02.SetFixedPosition(2, 325, 310, 120);

            document.Add(tables02);



            Paragraph para3 = new Paragraph(genpdf.Param2)
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 300, 276);
            document.Add(para3);


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
                .Add(new Paragraph(genpdf.Col1Param2));

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
               .Add(new Paragraph(genpdf.Col2Param2));

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
               .Add(new Paragraph(genpdf.Col3Param2));

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
               .Add(new Paragraph(genpdf.Col4Param2));



            // Adicione as células à linha
            tables03.AddCell(cells05);
            tables03.AddCell(cells06);
            tables03.AddCell(cells07);
            tables03.AddCell(cells08);


            tables03.SetFixedPosition(2, 325, 296, 120);

            document.Add(tables03);


            Paragraph para4 = new Paragraph(genpdf.Param3)
                .SetMarginRight(0).SetPaddingRight(0)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)                 
            .SetFixedPosition(2, 20, 285, 276);
            document.Add(para4);


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
                .Add(new Paragraph(genpdf.Col1Param3));

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
               .Add(new Paragraph(genpdf.Col2Param3));

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
               .Add(new Paragraph(genpdf.Col3Param3));

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
               .Add(new Paragraph(genpdf.Col4Param3));



            // Adicione as células à linha
            tables04.AddCell(cells09);
            tables04.AddCell(cells10);
            tables04.AddCell(cells11);
            tables04.AddCell(cells12);


            tables04.SetFixedPosition(2, 325, 280, 120);

            document.Add(tables04);


            Paragraph para5 = new Paragraph(genpdf.Param4)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(8) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(20)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 266, 276);
            document.Add(para5);


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
                .Add(new Paragraph(genpdf.Col1Param4));

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
               .Add(new Paragraph(genpdf.Col2Param4));

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
               .Add(new Paragraph(genpdf.Col3Param4));

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
               .Add(new Paragraph(genpdf.Col4Param4));



            // Adicione as células à linha
            tables05.AddCell(cells011);
            tables05.AddCell(cell12);
            tables05.AddCell(cells13);
            tables05.AddCell(cells14);


            tables05.SetFixedPosition(2, 325, 265, 120);

            document.Add(tables05);



            Paragraph para6 = new Paragraph(genpdf.Param5)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40)
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 242, 276);
            document.Add(para6);


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
                .Add(new Paragraph(genpdf.ColParam5));


            // Adicione as células à linha
            tables06.AddCell(cells015);
           

            tables06.SetFixedPosition(2, 325, 240, 200);

            document.Add(tables06);



            Paragraph para7 = new Paragraph(genpdf.Param6)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 228, 276);
            document.Add(para7);


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
                .Add(new Paragraph(genpdf.Col1Param6));

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
               .Add(new Paragraph(genpdf.Col2Param6));

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
               .Add(new Paragraph(genpdf.Col3Param6));

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
               .Add(new Paragraph(genpdf.Col4Param6));



            // Adicione as células à linha
            tables07.AddCell(cells016);
            tables07.AddCell(cell17);
            tables07.AddCell(cells18);
            tables07.AddCell(cells19);


            tables07.SetFixedPosition(2, 325, 225, 120);
             
            document.Add(tables07);



            Paragraph para8 = new Paragraph(genpdf.Param7)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 214, 276);
            document.Add(para8);


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
                .Add(new Paragraph(genpdf.Col1Param7));

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
               .Add(new Paragraph(genpdf.Col2Param7));

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
               .Add(new Paragraph(genpdf.Col3Param7));

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
               .Add(new Paragraph(genpdf.Col4Param7));



            // Adicione as células à linha
            tables08.AddCell(cells020);
            tables08.AddCell(cell21);
            tables08.AddCell(cells22);
            tables08.AddCell(cells23);


            tables08.SetFixedPosition(2, 325, 214, 120);

            document.Add(tables08);



            Paragraph para9 = new Paragraph(genpdf.Param8)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 197, 276);
            document.Add(para9);


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
                .Add(new Paragraph(genpdf.Col1Param8));

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
               .Add(new Paragraph(genpdf.Col2Param8));

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
               .Add(new Paragraph(genpdf.Col3Param8));

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
               .Add(new Paragraph(genpdf.Col4Param8));



            // Adicione as células à linha
            tables09.AddCell(cells024);
            tables09.AddCell(cell25);
            tables09.AddCell(cells26);
            tables09.AddCell(cells27);


            tables09.SetFixedPosition(2, 325, 197, 120);

            document.Add(tables09);



            Paragraph para10 = new Paragraph(genpdf.Param9)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9) 
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5) 
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 180, 276);
            document.Add(para10);


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
                .Add(new Paragraph(genpdf.Col1Param9));

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
               .Add(new Paragraph(genpdf.Col2Param9));

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
               .Add(new Paragraph(genpdf.Col3Param9));

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
               .Add(new Paragraph(genpdf.Col4Param9));



            // Adicione as células à linha
            tables10.AddCell(cells029);
            tables10.AddCell(cell30);
            tables10.AddCell(cells31);
            tables10.AddCell(cells32);


            tables10.SetFixedPosition(2, 325, 180, 120);

            document.Add(tables10);


            Paragraph para11 = new Paragraph(genpdf.Param10)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                  .SetFontSize(9)
                  .SetMarginLeft(40) 
                  .SetMarginBottom(5)
                  .SetFont(font4)
            .SetFixedPosition(2, 20, 166, 276);
            document.Add(para11);


            Table tables012 = new Table(4);

            // Crie a imagem
            ImageData imageData11 = ImageDataFactory.Create(genpdf.UrlImageEfficientEnergyParam10);
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

            document.Add(tables012);



            Paragraph para12 = new Paragraph(genpdf.Param11)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.RIGHT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                 .SetFontSize(9) 
                 .SetMarginLeft(40) 
                 .SetMarginBottom(5) 
                 .SetFont(font4)
           .SetFixedPosition(2, 20, 135, 276);
            document.Add(para12);

            Paragraph paraDetails12 = new Paragraph(genpdf.ParamTextUnder)
                 .SetMarginRight(0).SetPaddingRight(0)
                 .SetTextAlignment(TextAlignment.LEFT)
                 .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
                 .SetFontSize(6)
                 .SetMarginLeft(40)
                 .SetMarginBottom(5)
                 .SetFont(font4)
           .SetFixedPosition(2, 325, 125, 180);
            document.Add(paraDetails12);

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
                .Add(new Paragraph(genpdf.Col1Param11));

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
               .Add(new Paragraph(genpdf.Col2Param11));

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
               .Add(new Paragraph(genpdf.Col3Param11));

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
               .Add(new Paragraph(genpdf.Col4Param11));



            // Adicione as células à linha
            tables11.AddCell(cells037);
            tables11.AddCell(cell38);
            tables11.AddCell(cells39);
            tables11.AddCell(cells40);


            tables11.SetFixedPosition(2, 325, 135, 120);

            document.Add(tables11);





            //##################################################################### ------------------------- ##################################################################################
            //-------------------------------- FOOTER ------------------------------------

            PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            Paragraph TitleFooter = new Paragraph(genpdf.TitleFooter2)
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

            Paragraph paragraphFooter3 = new Paragraph(genpdf.SubTitleFooter2)
               .SetFontSize(7)
               //.SetMarginLeft(10)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER)
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFixedPosition(2, -150, 70, 900)
               .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraphFooter3);


            Paragraph paragraphFooter2 = new Paragraph(genpdf.TextFooter2)
               .SetFontSize(7)
               .SetMarginLeft(38)
               .SetHorizontalAlignment(HorizontalAlignment.CENTER) //----------------------------------------------------------------------------------------------
               .SetWidth(UnitValue.CreatePercentValue(50))
               .SetFixedPosition(2, 175, 50, 900)
               .SetFontColor(ColorConstants.BLACK);
            document.Add(paragraphFooter2);


            //##################################### IMAGEM 1 FOOTERS ############################################################
                        
            ImageData imageDatar02 = ImageDataFactory.Create(imagePath);
            Image img02 = new Image(imageDatar02);

            img02.ScaleAbsolute(40, 40);  // ajuste esses valores conforme necessário
            img02.SetFixedPosition(2, 240, 2, 1200);
            //img02.SetRelativePosition(1, 580, 50, 100);

            Paragraph footer02 = new Paragraph().Add(img02).SetTextAlignment(TextAlignment.CENTER);
            document.Add(footer02);


            //##################################### IMAGEM 2 FOOTERS ############################################################
                        
            ImageData imageDatar03 = ImageDataFactory.Create(imagePath08);
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
