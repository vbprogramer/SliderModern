<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SliderModern.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modern Slider</title>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <%--icon-tab--%>
    <link rel="icon" type="images/png" sizes="32x32" href="/images/Sp.png" />
    <!--swiper css-->
    <link href="css/swiper-bundle.min.css" rel="stylesheet" />
    <!--css-->
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="naslovljeno">
                <h3>Modern slider</h3>
            </div>
            <%--slider--%>
<section class="slide-container-section">
      <div class="slide-container swiper">
            <div class="slide-content">
                <div class="card-wrapper swiper-wrapper">
                    <div class="card swiper-slide">
                        <div class="image-content">
                            <span class="overlay"></span>
                                <div class="card-image">
                                    <asp:Image ID="Image1" runat="server" class="card-img" />
                                </div>
                        </div>
                            <div class="card-content">
                                <asp:Label ID="Label1" runat="server" class="name"></asp:Label>
                                <asp:Label ID="Label2" runat="server" class="description" Style="text-overflow: ellipsis; display: inline-block;position: relative; overflow: hidden;  width: 200px; white-space: nowrap; padding: 2px; margin-right: 15px;"></asp:Label>
                                <asp:Button ID="Oglas1" runat="server" Text="DETAIL" class="button" OnClick="Oglas1_Click" />
                            </div>
                    </div>
                    <div class="card swiper-slide">
                        <div class="image-content">
                            <span class="overlay"></span>
                                <div class="card-image">
                                    <asp:Image ID="Image2" runat="server" class="card-img" />
                                </div>
                        </div>
                            <div class="card-content">
                                <asp:Label ID="Label3" runat="server" class="name"></asp:Label>
                                <asp:Label ID="Label4" runat="server" class="description" Style="text-overflow: ellipsis; display: inline-block;position: relative; overflow: hidden;  width: 200px; white-space: nowrap; padding: 2px; margin-right: 15px;"></asp:Label>
                                <asp:Button ID="Oglas2" runat="server" Text="DETAIL" class="button" OnClick="Oglas2_Click" />
                            </div>
                    </div>
                    <div class="card swiper-slide">
                        <div class="image-content">
                            <span class="overlay"></span>
                                <div class="card-image">
                                    <asp:Image ID="Image3" runat="server" class="card-img" />
                                </div>
                        </div>
                            <div class="card-content">
                                <asp:Label ID="Label5" runat="server" class="name"></asp:Label>
                                <asp:Label ID="Label6" runat="server" class="description" Style="text-overflow: ellipsis; display: inline-block;position: relative; overflow: hidden;  width: 200px; white-space: nowrap; padding: 2px; margin-right: 15px;"></asp:Label>
                                <asp:Button ID="Oglas3" runat="server" Text="DETAIL" class="button" OnClick="Oglas3_Click" />
                            </div>
                    </div>
                    <div class="card swiper-slide">
                        <div class="image-content">
                            <span class="overlay"></span>
                                <div class="card-image">
                                    <asp:Image ID="Image4" runat="server" class="card-img" />
                                </div>
                        </div>
                            <div class="card-content">
                                 <asp:Label ID="Label7" runat="server" class="name"></asp:Label>
                                <asp:Label ID="Label8" runat="server" class="description" Style="text-overflow: ellipsis; display: inline-block;position: relative; overflow: hidden;  width: 200px; white-space: nowrap; padding: 2px; margin-right: 15px;"></asp:Label>
                                <asp:Button ID="Oglas4" runat="server" Text="DETAIL" class="button" OnClick="Oglas4_Click" />
                            </div>
                    </div>
                    <div class="card swiper-slide">
                        <div class="image-content">
                            <span class="overlay"></span>
                                <div class="card-image">
                                    <asp:Image ID="Image5" runat="server" class="card-img" />
                                </div>
                        </div>
                            <div class="card-content">
                                <asp:Label ID="Label9" runat="server" class="name"></asp:Label>
                                 <asp:Label ID="Label10" runat="server" class="description" Style="text-overflow: ellipsis; display: inline-block;position: relative; overflow: hidden;  width: 200px; white-space: nowrap; padding: 2px; margin-right: 15px;"></asp:Label>
                                 <asp:Button ID="Oglas5" runat="server" Text="DETAIL" class="button" OnClick="Oglas5_Click" />
                            </div>
                    </div>
                    <div class="card swiper-slide">
                        <div class="image-content">
                            <span class="overlay"></span>
                                <div class="card-image">
                                    <asp:Image ID="Image6" runat="server" class="card-img" />
                                </div>
                        </div>
                            <div class="card-content">
                                 <asp:Label ID="Label11" runat="server" class="name"></asp:Label>
                                 <asp:Label ID="Label12" runat="server" class="description" Style="text-overflow: ellipsis; display: inline-block;position: relative; overflow: hidden;  width: 200px; white-space: nowrap; padding: 2px; margin-right: 15px;"></asp:Label>
                                 <asp:Button ID="Oglas6" runat="server" Text="DETAIL" class="button" OnClick="Oglas6_Click" />
                            </div>
                    </div>
                </div>
            </div>
            <div class="swiper-button-next swiper-navBtn"></div>
            <div class="swiper-button-prev swiper-navBtn"></div>
            <div class="swiper-pagination"></div>
        </div>
</section>
            <%--end-slider--%>
    </form>
</body>
     <%--swipper js--%>
<script src="js/swiper-bundle.min.js"></script>
    <%--script1-slider--%>
<script src="js/script.js"></script>
</html>
