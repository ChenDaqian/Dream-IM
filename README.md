皮肤:LesslsMore
页面定制CSS代码
::-webkit-scrollbar {
    width: 6px;
    height: 6px;
}

::-webkit-scrollbar-thumb {
    background-color: #55895B;
    border-radius: 5px;
}

::-webkit-scrollbar-thumb:hover {
    background-color: #55895B;
}

::selection {
    color: white;
    background: rgb(215,48,48);
}

::-moz-selection {
    color: white;
    background: rgb(215,48,48);
}

::-webkit-selection {
    color: white;
    background: rgb(215,48,48);
}

blockquote {
    margin: 20px 0;
    padding: 20px 50px;
    border-radius: 10px;
    background: url('http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_quote.png') no-repeat -75px -20px #f0f0f0;
    -ms-border-radius: 10px;
}

/*bug gotop*/
.ico-qxpc {
    /*display: inline-block;*/
    /*width: 24px;*/
    /*height: 24px;*/
    position: fixed;
    right: 0;
    bottom: -8px;
    -webkit-transition: bottom .3s ease;
    transition: bottom .3s ease;
}

.ico-qxpc:hover {
    bottom: 0;
    -webkit-transition: bottom .8s ease;
    transition: bottom .8s ease;
}

/*metro gotop*/
ul,
li {
    margin: 0;
    padding: 0;
}

ul {
    list-style: none;
}

.clearfix:before,
.clearfix:after {
    display: table;
    content: '';
}

.clearfix:after {
    clear: both;
}

.clearfix {
    zoom: 1;
}

.ff-t {
    font-family: Tahoma;
}

.scrollBtn {
    position: fixed;
    right: 15px;
    bottom: 45px;
    width: 54px;
    _position: absolute;
}

.scrollBtn a {
    display: inline-block;
    overflow: hidden;
    width: 54px;
    height: 54px;
    -webkit-transition: opacity .5s ease;
    -moz-transition: opacity .5s ease;
    -o-transition: opacity .5s ease;
    transition: opacity .5s ease;
    text-align: center;
    opacity: .6;
    color: white;
    background: url(http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_gototop.png) no-repeat 0 0;
    filter: Alpha(Opacity=60);
}

.scrollBtn li {
    float: left;
    overflow: hidden;
    height: 54px;
    margin-bottom: 5px;
}

.scrollBtn a:hover {
    opacity: 1;
    filter: Alpha(Opacity=100);
}

/*评论*/
.sB-comment a {
    height: 17px;
    padding-top: 34px;
    padding-bottom: 3px;
    background-position: 0 -59px;
}
/*关注*/
.sB-share a {
    background-position: 0 -118px;
}

/*返回顶部*/
.sB-goTop a {
    background-position: 0 -177px;
}

/*博客模板*/
/*公用*/
body {
    font-family: '微软雅黑','宋体',Arial;
    font-size: 15px;
    min-width: 1200px;
    margin: 0;
    padding: 0;
    background: #205424 url('http://mat1.gtimg.com/www/mb/theme/qqfs/one_lhj/wrapBg.jpg') no-repeat top center fixed;
}

#home {
    overflow: auto;
    width: 1200px;
    margin: 40px auto;
    opacity: 0.95;
    border: solid 1px white;
    border-radius: 0 350px 0 0;
    background: white;
    box-shadow: 0 0 10px #000;
    filter: alpha(opacity=90);
}
/*段落*/
.postBody p,
.postCon p {
    line-height: 24px;
    margin: 7px 0;
}

ul {
    margin: 0;
    padding: 0;
    list-style: none;
}

image {
    border: none;
}

#header {
    padding: 10px;
}

#blogTitle .title {
    font-size: 36px;
    line-height: 100px;
    height: 100px;
    padding-left: 120px;
    background: white url('http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_vslogo.png') no-repeat;
}

/*子标题*/
.subtitle {
    font-size: 14px;
    font-weight: normal;
    margin: 10px 0;
    padding-left: 30px;
    color: #999;
}
/*导航栏*/
#navigator {
    font-size: 16px;
    height: 48px;
    margin-top: 20px;
    margin-bottom: 20px;
    text-align: center;
    background: #55895b;
}

#navList li {
    line-height: 48px;
    display: inline-block;
    float: left;
    margin: 0;
}

#navList li:hover {
    background: #6da47d;
}

#navList li a {
    line-height: 48px;
    display: -moz-inline-box;
    display: inline-block;
    padding: 0 30px;
    text-decoration: none;
    color: white;
    border: 0;
}

.blogStats {
    line-height: 48px;
    height: 48px;
    color: white;
}

#main {
    padding: 10px;
}
/*左边*/
#sideBarMain {
    font-size: 12px;
    line-height: 22px;
    width: 190px;
    margin: 0 0 20px 0;
    padding: 0 10px 0 0;
    border-right: 1px dashed #bec7c2;
    background: white;
}

/*公告*/
#profile_block {
    line-height: 24px;
    text-align: left;
}
/*主面板*/
#mainContent {
    float: right;
    width: 960px;
    margin-top: 0;
    padding-top: 0;
    padding-right: 0;
    padding-bottom: 0;
    padding-left: 10px;
    background: white;
}
/*每日文章列表*/
.day {
    margin: 0 0 20px 0;
    padding: 0;
    background: white;
}
/*博客标题*/
.postTitle a {
    color: #464646;
}

.postTitle {
    font-size: 20px;
    font-weight: bold;
    padding-bottom: 10px;
    padding-left: 30px;
    color: #464646;
    background: url('http://images.cnblogs.com/cnblogs_com/libaoheng/305804/o_br229512.link(en-us,MSDN.10).gif') no-repeat 0 3px;
}

.dayTitle {
    display: none;
}
/*摘要*/
.c_b_p_desc {
    line-height: 24px;
    padding: 40px 5px 10px 30px;
    color: #888;
    border-radius: 12px;
    background: url('http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_quote.png') no-repeat -75px -20px #f0f0f0;
    -ms-border-radius: 10px;
}

.c_b_p_desc a {
    color: #888;
}
/*右侧图片*/
.desc_img {
    margin-left: 10px;
    border: solid 1px white;
    box-shadow: 0 0 10px #aaa;
}
/*博文页*/
#topics .post {
    background: white;
}

.postCon {
    padding: 10px 20px 0 20px;
}

.postDesc {
    font-size: 12px;
    margin: 0 30px;
    margin-bottom: 2px;
    padding: 8px 0;
    text-align: right;
    color: #aaa;
    background: white;
}

.postDesc a {
    color: #aaa;
}

.postBody {
    padding: 0;
}
/*google搜索框*/
#google_q,
#q {
    width: 120px;
    border: solid 1px #ccc;
    border-radius: 4px;
}
/*搜索按钮*/
.btn_my_zzk {
    font-family: 'Microsoft Yahei';
    font-size: 14px;
    position: relative;
    display: inline-block;
    width: 60px;
    height: 26px;
    padding: 1px;
    cursor: pointer;
    vertical-align: middle;
    color: white;
    border: none;
    border-radius: 4px;
    background: #55895b;
}

.btn_my_zzk:hover {
    background: #6da47d;
}

/*顶一下,踩一下*/
#div_digg {
    font-size: 12px;
    right: 0;
    bottom: 0;
    float: right;
    width: 125px;
    margin-top: 0;
    margin-top: 10px;
    margin-right: 0;
    margin-bottom: 0;
    margin-left: 0;
    padding: 5px;
    text-align: center;
    text-align: center;
    border: 3px solid #55895b;
    border-radius: 5px;
}

#digg_tips {
    display: none;
}
/*评论按钮*/

#btn_comment_submit {
    width: 120px;
    height: 48px;
    border: none;
}
/*评论按钮*/
.comment_btn {
    font-family: 'Microsoft Yahei';
    font-size: 18px;
    position: relative;
    display: inline-block;
    width: 120px;
    height: 48px;
    cursor: pointer;
    vertical-align: middle;
    color: white;
    border: none;
    background: #55895b;
}

#btn_comment_submit:hover {
    background: #6da47d;
}
/*评论标题*/
.feedback_area_title {
    font-size: 24px;
    font-weight: bold;
    padding: 10px;
    color: #55895b;
    border-bottom: solid 6px #55895b;
}

.feedbackListSubtitle {
    font-size: 12px;
    color: #888;
}

.feedbackListSubtitle a {
    color: #888;
}

#commentform_title {
    font-size: 24px;
    font-weight: bold;
    margin-bottom: 10px;
    padding: 10px 20px 10px 10px;
    color: #55895b;
    border-bottom: solid 6px #55895b;
    background-image: none;
    background-repeat: no-repeat;
}
/*评论框*/
#comment_form {
    margin: 10px 0;
    padding: 0;
}

.commentform {
    margin: 10px 0;
    padding: 10px 20px;
    background: white;
}
/*评论输入域*/
#tbCommentBody {
    font-size: 14px;
    line-height: 1.42857143;
    width: 940px;
    height: 200px;
    padding: 5px 12px;
    -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
    -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
    transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
    color: #3c763d;
    border: 1px solid #ccc;
    border-radius: 4px;
    background: white url(http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_A.png) right bottom no-repeat;
    background-color: white;
    -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
    box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
}
/*评论条目*/
.feedbackItem {
    font-size: 14px;
    line-height: 24px;
    margin: 10px 0;
    padding: 20px;
    background: #f2f2f2;
    box-shadow: 0 0 5px #aaa;
}

.feedbackListSubtitle {
    font-weight: normal;
}

/*尾部*/
#footer {
    font-size: 12px;
    font-size: 14px;
    margin: 20px;
    padding: 12px;
    text-align: center;
    color: #ddd;
    background: #55895b;
}

/*公告标题*/
.catListTitle {
    padding: 5px;
    border: 1px solid #eee;
    border-left-width: 5px;
    border-left-color: #55895b;
    border-radius: 3px;
    background-color: white;
}

#green_channel {
    font-size: 15px;
    font-weight: normal;
    width: 920px;
    padding: 20px;
    padding-left: 20px;
    color: white;
    border: none;
    border-radius: 4px;
    background: #6da47d;
}

/*最新评论*/
/*#myposts .PostList {
    font-size: 14px;
    line-height: 24px;
    margin: 10px 0;
    padding: 20px;
    background: #f2f2f2;
    box-shadow: 0 0 5px #aaa;
}

#myposts .postTitl2 a {
    color: #6da47d;
}*/

code {
    padding: 2px 4px;
    white-space: nowrap;
    color: rgb(221, 17, 68);
    border: 1px solid rgb(225, 225, 232);
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    background-color: rgb(247, 247, 249);
}

kbd {
    font-family: Arial,Helvetica,sans-serif;
    font-size: 11px;
    line-height: 1.4;
    display: inline-block;
    margin: 0 .1em;
    padding: .1em .6em;
    color: rgb(51, 51, 51);
    border: 1px solid rgb(204, 204, 204);
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    background-color: rgb(247, 247, 247);
    -webkit-box-shadow: 0 1px 0 rgba(0, 0, 0, .2),0 0 0 2px rgb(255, 255, 255) inset;
    -moz-box-shadow: 0 1px 0 rgba(0,0,0,.2),0 0 0 2px white inset;
    box-shadow: 0 1px 0 rgba(0, 0, 0, .2),0 0 0 2px rgb(255, 255, 255) inset;
    text-shadow: 0 1px 0 rgb(255, 255, 255);
}

/*图片旋转*/
.headph:hover img {
    -webkit-transform: rotate(360deg) scale(1.5);
    -moz-transform: rotate(360deg) scale(1.5);
    -ms-transform: rotate(360deg) scale(1.5);
    -o-transform: rotate(360deg) scale(1.5);
    transform: rotate(360deg) scale(1.5);
}

.headph img {
    width: 48px;
    height: 48px;
    -webkit-transition: all 1s ease-in-out;
    -moz-transition: all 1s ease-in-out;
    -ms-transition: all 1s ease-in-out;
    -o-transition: all 1s ease-in-out;
    transition: all 1s ease-in-out;
}

/*自定义标题*/
.Abstract {
    font-family: 'Microsoft Yahei';
    padding: 15px;
    color: #999;
    border: dotted 2px #999;
    border-radius: 4px;
}

.First {
    font-family: 'Microsoft Yahei';
    font-size: 20px;
    clear: both;
    margin: 10px 0;
    padding: 6px 20px;
    text-align: left;
    color: white;
    border-radius: 4px;
    background: #55895b;
}

.Second {
    font-family: 'Microsoft Yahei';
    font-size: 18px;
    clear: both;
    margin: 10px 0;
    padding: 6px 20px;
    color: white;
    border-radius: 4px;
    background: #93c8a2;
}

.Third {
    font-family: 'Microsoft Yahei';
    font-size: 16px;
    clear: both;
    margin: 10px 0;
    margin: 15px 0;
    padding: 6px 20px;
    color: white;
    color: #999;
    border-radius: 4px;
    background: #c6efd2;
}

.note {
    font-family: 'Microsoft Yahei';
    font-size: 15px;
    clear: both;
    margin: 10px 0;
    padding: 15px 20px 15px 60px;
    background: #fcfaa9 url('http://images.cnblogs.com/cnblogs_com/libaoheng/305804/o_yellow-pin.png') no-repeat 20px 0;
    box-shadow: 0 0 8px #aaa;
}

.demo {
    font-size: 16px;
    clear: both;
    overflow: auto;
    padding: 6px 20px;
    text-align: left;
    color: white;
    border-radius: 4px;
    background: orange;
}

/*syntaxhighlighter去掉行变色*/
.syntaxhighlighter .line.alt2 {
    background-color: white !important;
}

div.catListView a:hover,
div.catListFeedback a:hover,
div.catListBlogRank a:hover,
div.catList a:hover,
div.catListImageCategory a:hover,
div.catListPostArchive a:hover,
div.catListPostCategory a:hover,
div.catListLink a:hover,
div#profile_block a:hover,
div#blog-comments-placeholder a:hover,
div#comment_form a:hover {
    color: #8acc43;
}

#BlogPostCategory a,
.catListTag a,
#RecentCommentsBlock a,
#topics a:hover,
#LauncherLogoLink :hover {
    padding: 1px 3px 1px 3px;
    text-decoration: none;
    color: white;
    border-radius: 3px;
    background-color: #55895b;
}

h1 {
    margin: 0;
}

h3 {
    font-size: 15px;
    font-weight: bold;
}
/*超链接*/
a {
    text-decoration: none;
    color: #464646;
}

a:visited,
a:hover {
    color: #464646;
}

.postBody .First a {
    color: white;
}

.postBody a:hover {
    text-decoration: none;
    color: white;
    background-color: #55895b;
}

.postBody a {
    padding: 1px 3px 1px 3px;
    color: #55895b;
}
博客侧边栏公告（支持HTML代码）（支持JS代码）:
<div id="info">
        <div id="clock">
            <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0" width="160" height="70" id="honehoneclock" align="middle">
                <param name="allowScriptAccess" value="always">
                <param name="movie" value="http://chabudai.sakura.ne.jp/blogparts/honehoneclock/honehone_clock_tr.swf">
                <param name="quality" value="high">
                <param name="bgcolor" value="#ffffff">
                <param name="wmode" value="transparent">
                <embed wmode="transparent" src="http://chabudai.sakura.ne.jp/blogparts/honehoneclock/honehone_clock_tr.swf" quality="high" bgcolor="#ffffff" width="160" height="70" name="honehoneclock" align="middle" allowscriptaccess="always" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer">
            </object>
        </div>
        <div id="picture">
            <img style="margin-top: 1px; width: 190px;" title="Chenx" alt="Chenx" src="http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_WP_20130506_001.png" />
        </div>
        <div id="map">
            <a href="http://www2.clustrmaps.com/user/46410f7f7">
                <img style="margin-top: 1px; width: 190px;" src="http://www2.clustrmaps.com/stats/maps-no_clusters/www.cnblogs.com-ChenXu-net--thumb.jpg" alt="Locations of visitors to this page" title="map" />
            </a>
        </div>
        <div id="douban">
            <script type="text/javascript" src="http://www.douban.com/service/badge/120676091/?selection=latest&amp;picsize=small&amp;hideself=on&amp;show=collection&amp;n=8&amp;cat=drama%7Cmovie%7Cbook%7Cmusic&amp;columns=2"></script>
        </div>
        <ul style="color: black;">
            <li>
                <a href="http://weibo.com/u/2572403114" target="_blank"><img src="http://static.cnblogs.com/images/icon_weibo_24.png" alt="weibo"></a>
                <a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=644733521&site=qq&menu=yes">
                    <img border="0" src="http://wpa.qq.com/pa?p=2:644733521:52" alt="点击这里给我发消息" title="点击这里给我发消息" />
                </a>
            </li>
            <li>
                <input type="button" class="btn_my_zzk" id="btnRead" value="阅读模式" onclick="readPattern();">
            <li>
                <!--<li>
                    <div id='MicrosoftTranslatorWidget' class='Dark' style='color: white; background-color: #555555'></div>
                    <script type='text/javascript'>setTimeout(function () { { var s = document.createElement('script'); s.type = 'text/javascript'; s.charset = 'UTF-8'; s.src = ((location && location.href && location.href.indexOf('https') == 0) ? 'https://ssl.microsofttranslator.com' : 'http://www.microsofttranslator.com') + '/ajax/v3/WidgetV3.ashx?siteData=ueOIGRSKkd965FeEGM5JtQ**&ctf=True&ui=true&settings=Manual&from=zh-CHS'; var p = document.getElementsByTagName('head')[0] || document.documentElement; p.insertBefore(s, p.firstChild); } }, 0);</script>
                </li>-->
            <li>&nbsp;</li>
            <li>
                <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" autostart="1" autoplay="1" data="http://files.cnblogs.com/ChenXu-net/dewplayer_blue.swf" width="190" height="20" id="dewplayerclassic" name="dewplayerclassic" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/
swflash.cab#version=7,0,0,0">
                    <param name="allowScriptAccess" value="sameDomain" />
                    <param name="movie" value="http://files.cnblogs.com/ChenXu-net/dewplayer_blue.swf?mp3=http://www.qlcoder.com//uploads/45fd03c947/148851259634257.mp3">
                    <param name="flashvars" value="mp3=http://www.qlcoder.com//uploads/45fd03c947/148851259634257.mp3">
                    <param name="quality" value="high" />
                    <embed src="http://files.cnblogs.com/ChenXu-net/dewplayer_blue.swf?mp3=http://www.qlcoder.com//uploads/45fd03c947/148851259634257.mp3"
                           quality="high"
                           width="190"
                           height="20"
                           name="mymovie"
                           align="center"
                           autostart="1"
                           allowscriptaccess="sameDomain"
                           type="application/x-shockwave-flash"
                           pluginspage="http://www.macromedia.com/go/getflashplayer" />
                </object>
            </li>
        </ul>
    </div>

页首Html代码:
<link href="http://files.cnblogs.com/ChenXu-net/pace.css" rel="stylesheet" />
<link href="http://files.cnblogs.com/kenshincui/CNBlogsNavigation-0.5.2.min.css" rel="stylesheet">
<script type="text/javascript" src="http://files.cnblogs.com/ChenXu-net/pace.js"></script>
<!--<script type="text/javascript" src="http://blogparts.giffy.me/0013/parts.js"></script>-->
<script type="text/javascript" src="http://files.cnblogs.com/files/ChenXu-net/jquery.nicescroll.min.js"></script>
<!--<script src="http://files.cnblogs.com/kenshincui/CNBlogsNavigation-0.5.2.min.js"></script>-->
<script type="text/javascript">
    $(function () {
        //$("html").niceScroll({ styler: "fb", cursorcolor: "#000" });

        //baiduSearch.js 选中文字百度搜索
        //$.getScript('http://s1.bdstatic.com/r/www/cache/baidu_search/baiduSearch-1.4.js', function (){
        //    baidusearch.init("644733521@qq.com");
        //});

        console.log("          _____                    _____                    _____                    _____          \n         /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\         \n        /::\\____\\                /::\\    \\                /::\\    \\                /::\\    \\        \n       /:::/    /                \\:::\\    \\              /::::\\    \\              /::::\\    \\       \n      /:::/    /                  \\:::\\    \\            /::::::\\    \\            /::::::\\    \\      \n     /:::/    /                    \\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\     \n    /:::/____/                      \\:::\\    \\        /:::/__\\:::\\    \\        /:::/__\\:::\\    \\    \n   /::::\\    \\                      /::::\\    \\      /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\   \n  /::::::\\    \\   _____    ____    /::::::\\    \\    /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\  \n /:::/\\:::\\    \\ /\\    \\  /\\   \\  /:::/\\:::\\    \\  /:::/\\:::\\   \\:::\\____\\  /:::/\\:::\\   \\:::\\    \\ \n/:::/  \\:::\\    /::\\____\\/::\\   \\/:::/  \\:::\\____\\/:::/  \\:::\\   \\:::|    |/:::/__\\:::\\   \\:::\\____\\\n\\::/    \\:::\\  /:::/    /\\:::\\  /:::/    \\::/    /\\::/   |::::\\  /:::|____|\\:::\\   \\:::\\   \\::/    /\n \\/____/ \\:::\\/:::/    /  \\:::\\/:::/    / \\/____/  \\/____|:::::\\/:::/    /  \\:::\\   \\:::\\   \\/____/ \n          \\::::::/    /    \\::::::/    /                 |:::::::::/    /    \\:::\\   \\:::\\    \\     \n           \\::::/    /      \\::::/____/                  |::|\\::::/    /      \\:::\\   \\:::\\____\\    \n           /:::/    /        \\:::\\    \\                  |::| \\::/____/        \\:::\\   \\::/    /    \n          /:::/    /          \\:::\\    \\                 |::|  ~|               \\:::\\   \\/____/     \n         /:::/    /            \\:::\\    \\                |::|   |                \\:::\\    \\         \n        /:::/    /              \\:::\\____\\               \\::|   |                 \\:::\\____\\        \n        \\::/    /                \\::/    /                \\:|   |                  \\::/    /        \n         \\/____/                  \\/____/                  \\|___|                   \\/____/         \n");
        $('head').append('<link href="http://www.qlcoder.com//uploads/45fd03c947/148852114364248.ico" type="image/x-icon" rel="shortcut icon" />');
        document.title = "陈大欠";
        setInterval(function () {
            if (document.title == '陈大欠') {
                document.title = "瞄瞄喵";
            } else {
                document.title = "陈大欠";
            }
        }, 1500)

        $("a[class=ico-qxpc]").click(function (e) {
            readPattern();
        });

        $("li[id=goTop]").click(function (e) {
            e.preventDefault();//阻止默认事件
            $('html,body').animate({
                'scrollTop': 0
            }, 'slow');
        });

        $(window).scroll(function (e) {
            var h = $(window).height();
            var t = $(document).scrollTop();
            if (t > h) {
                $('#goTop').show();
            } else {
                $('#goTop').hide();
            }
        });

        $(window).resize(function () {
            setBugPosition();
        });

        setBugPosition();
    });

    function setBugPosition() {
        //设置虫子位置
        var mainElement = $("#main");
        var pLeft = mainElement.width() + mainElement.offset().left;
        $(".ico-qxpc").css("left", pLeft + 10);
    }

    function readPattern() {
        var operator = $("a[name=top]").attr("reader");
        if (operator == "true") {
            $("a[name=top]").attr("reader", false)
            $("#sideBar").show();
            $("#mainContent").animate({ marginLeft: '0px', marginRight: '5px' }, 1000);

        } else {
            $("a[name=top]").attr("reader", true)
            $("#sideBar").hide();
            $("#mainContent").animate({ marginLeft: '150px', marginRight: '150px' }, 1000);
        }
    }
</script>

页脚Html代码:
<a href="https://github.com/opencx"><img style="position: absolute; top: 0; right: 0; border: 0;" src="https://camo.githubusercontent.com/e7bbb0521b397edbd5fe43e7f760759336b5e05f/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f6769746875622f726962626f6e732f666f726b6d655f72696768745f677265656e5f3030373230302e706e67" alt="Fork me on GitHub" data-canonical-src="https://s3.amazonaws.com/github/ribbons/forkme_right_green_007200.png"></a>
    <a id="aGotop" href="javascript:void(0)" class="ico-qxpc">
        <img id="imgBug" src="http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_bug.gif" alt="Got top" title="千万别点我~">
    </a>
    <div class="scrollBtn" id="scrollBtn">
        <ul class="clearfix">
            <li class="sB-home">
                <a href="http://www.cnblogs.com/ChenXu-net" class="ff-t" id="goHome" title="home">
                </a>
            </li>
            <li class="sB-comment">
                <a href="#blog-comments-placeholder" class="ff-t" id="goCmt" title="comment">
                </a>
            </li>
            <li class="sB-share">
                <a href="javascript:void(0)" onclick="follow('044d9d29-44e9-e111-aa3f-842b2b196315');" id="goAbout" title="follow">
                </a>
            </li>
            <li class="sB-goTop" id="goTop">
                <a href="javascript:void(0)" title="Got top">
                </a>
            </li>
        </ul>
    </div>
    <script type="text/javascript">
        //评论自定义头像
        $(window).load(function () {

            $.each($(".feedbackItem"), function (i, t) {
                var comt = $(this).find(".blog_comment_body");
                var commentBodyId = comt[0].id;
                var commentId = commentBodyId.substr(commentBodyId.lastIndexOf("_") + 1);
                var blogLink = $("#a_comment_author_" + commentId).attr("href");
                var imgURL = $("#comment_" + commentId + "_avatar").html();
                if (imgURL == null) {
                    imgURL = 'http://images.cnblogs.com/cnblogs_com/ChenXu-net/517141/o_vslogo.png';
                }

                //增加评论头像
                $(this).find("div.feedbackListSubtitle").before(
                    '<div style="margin: 0;position:relative;border-radius:5px;width: 49px; height: 49px;float:left;margin-right:25px;margin-top:10px;">' +
                        '<div class="headph">' +
                            '<a href="' + blogLink + '" target="_blank">' +
                                '<img src="' + imgURL + '" alt="AaronYang" style="border-radius:5px;border: medium none; background: none repeat scroll 0% 0% transparent; visibility: visible; padding: 0pt; margin: 0pt; width: 48px; height: 48px; clip: rect(0px, 94px, 94px, 0px); ">' +
                            '</a>' +
                        '</div>' +
                    '</div>'
                );

                var hasl = $(this).find("span.louzhu");
                if (hasl[0]) {
                    $(this).css({ "background": "#FCFAAA" });
                }
            });
        });
    </script>

    <!--<style>
        #sideToolbar {
            position: fixed;
            bottom: -12px;
            right: 25px;
            width: 250px;
            height: 440px;
        }

            #sideToolbar ul, #sideToolbar ol {
                padding: 0px;
            }

            #sideToolbar li {
                list-style: none;
            }

        #sideCatalog {
            background-color: #fff;
            padding-bottom: 10px;
            border-radius: 5px;
        }

        #sideCatalog-sidebar {
            -moz-border-bottom-colors: none;
            -moz-border-left-colors: none;
            -moz-border-right-colors: none;
            -moz-border-top-colors: none;
            background-color: #eaeaea;
            border-color: -moz-use-text-color #eaeaea;
            border-image: none;
            border-left: 1px solid #eaeaea;
            border-right: 1px solid #eaeaea;
            border-style: none solid;
            border-width: 0 1px;
            height: 353px;
            left: 5px;
            position: absolute;
            top: 0;
            width: 0;
        }

        #sideCatalog-catalog {
            height: 325px;
            padding-top: 18px;
            overflow: hidden;
            padding-left: 23px;
            position: relative;
        }

        #sideCatalog #sideCatalog-sidebar .sideCatalog-sidebar-top {
            cursor: pointer;
            top: 0;
        }

        #sideCatalog #sideCatalog-sidebar .sideCatalog-sidebar-bottom {
            bottom: 0;
        }

        #sideCatalog #sideCatalog-sidebar .sideCatalog-sidebar-top, #sideCatalog #sideCatalog-sidebar .sideCatalog-sidebar-bottom {
            background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll 0 -199px transparent;
            height: 10px;
            left: -5px;
            overflow: hidden;
            position: absolute;
            width: 10px;
        }

        #sideCatalog li {
            margin: 0px;
            padding: 0 7px;
            text-align: left;
            position: relative;
        }

            #sideCatalog li: hover {
                background-color: #f5f5f5;
            }

        #sideCatalog-catalog ul .active {
            background-color: #f5f5f5;
        }

        #sideCatalog-catalog .active a {
            color: #519cea;
        }

        #sideCatalog-catalog a: hover {
            color: #519cea;
        }

        #sideCatalog span: first-child {
            color: #999;
            font-family: Arial;
            font-size: 14px;
            font-weight: bold;
            padding-right: 5px;
        }

        #sideCatalog li.h2Offset {
            padding-left: 45px;
            text-indent: -25px;
        }

        #sideCatalog li.h3Offset {
            padding-left: 90px;
            text-indent: -50px;
        }

        #sideCatalog a {
            text-decoration: none;
            color: #555;
            font-weight: bold;
        }

        .sideCatalog-dot {
            background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") repeat scroll 0 -222px transparent;
            cursor: pointer;
            font-size: 12px;
            height: 10px;
            left: -20px;
            line-height: 12px;
            overflow: hidden;
            position: absolute;
            top: 4px;
            width: 6px;
        }

        #sideCatalog .highlight .sideCatalog-dot {
            background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll -271px -38px transparent;
            height: 13px;
            left: -23px;
            top: 3px;
            width: 18px;
        }

        #sideCatalogBtn {
            background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll 0 0 transparent;
            cursor: pointer;
            display: block;
            height: 45px;
            margin-bottom: 5px;
            margin-left: 5px;
            position: relative;
            width: 45px;
            margin-top: 10px;
            outline: 0;
        }

            #sideCatalogBtn: hover {
                background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll -154px 0 transparent;
            }

        .sideCatalogBtnDisable {
            background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll -104px 0 transparent !important;
        }

        #sideToolbar-up {
            background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll -1px -62px transparent;
            border-radius: 2px;
            display: block;
            height: 45px;
            margin-left: 5px;
            width: 45px;
            outline: 0;
        }

            #sideToolbar-up: hover {
                background: url("http://images.cnitblog.com/blog2015/294743/201503/sideToolbar.gif") no-repeat scroll -74px -62px transparent;
            }
    </style>
    <script>
        var a = $(document);
        a.ready(function () {
            var b = $('body'),
                d = 'sideToolbar',
                e = 'sideCatalog',
                f = 'sideCatalog-catalog',
                g = 'sideCatalogBtn',
                h = 'sideToolbar-up',
                i = '<div id="sideToolbar"style="display:none;">\<div class="sideCatalogBg"id="sideCatalog">\<div id="sideCatalog-sidebar">\<div class="sideCatalog-sidebar-top"></div>\<div class="sideCatalog-sidebar-bottom"></div>\</div>\<div id="sideCatalog-catalog">\<ul class="nav"style="width:225px;zoom:1">\</ul>\</div>\</div>\<a href="javascript:void(0);"id="sideCatalogBtn"class="sideCatalogBtnDisable"></a>\</div>',
                j = '',
                k = 200,
                l = 0,
                m = 0,
                n = 0,
                o, p = 13,
                q = true,
                r = true,
                s = b;
            if (s.length === 0) {
                return
            };
            b.append(i);
            o = s.find(':header');
            if (o.length > p) {
                r = false;
                var t = s.find('h2');
                var u = s.find('h3');
                if (t.length + u.length > p) {
                    q = false
                }
            };
            o.each(function (t) {
                var u = $(this),
                    v = u[0];

                var title = u.text();
                var text = u.text();

                u.attr('id', 'autoid-' + l + '-' + m + '-' + n)
                //if (!u.attr('id')) {
                //    u.attr('id', 'autoid-' + l + '-' + m + '-' + n)
                //};
                if (v.localName === 'h2') {
                    l++;
                    m = 0;
                    if (text.length > 14) text = text.substr(0, 12) + "...";
                    j += '<li><span>' + l + '&nbsp&nbsp</span><a href="#' + u.attr('id') + '" title="' + title + '">' + text + '</a><span class="sideCatalog-dot"></span></li>';
                } else if (v.localName === 'h3') {
                    m++;
                    n = 0;
                    if (q) {
                        if (text.length > 12) text = text.substr(0, 10) + "...";
                        j += '<li class="h2Offset"><span>' + l + '.' + m + '&nbsp&nbsp</span><a href="#' + u.attr('id') + '" title="' + title + '">' + text + '</a></li>';
                    }
                } else if (v.localName === 'h4') {
                    n++;
                    if (r) {
                        j += '<li class="h3Offset"><span>' + l + '.' + m + '.' + n + '&nbsp&nbsp</span><a href="#' + u.attr('id') + '" title="' + title + '">' + u.text() + '</a></li>';
                    }
                }
            });
            $('#' + f + '>ul').html(j);
            b.data('spy', 'scroll');
            b.data('target', '.sideCatalogBg');
            //$('body').scrollspy({
            //    target: '.sideCatalogBg'
            //});
            $sideCatelog = $('#' + e);
            $('#' + g).on('click', function () {
                if ($(this).hasClass('sideCatalogBtnDisable')) {
                    $sideCatelog.css('visibility', 'hidden')
                } else {
                    $sideCatelog.css('visibility', 'visible')
                };
                $(this).toggleClass('sideCatalogBtnDisable')
            });
            $('#' + h).on('click', function () {
                $("html,body").animate({
                    scrollTop: 0
                }, 500)
            });
            $sideToolbar = $('#' + d);
            a.on('scroll', function () {
                var t = a.scrollTop();
                if (t > k) {
                    $sideToolbar.css('display', 'block')
                } else {
                    $sideToolbar.css('display', 'none')
                }
            })
        });
    </script>-->  <script type="text/javascript" color="0,0,0" opacity="1"  count="99" src="//cdn.bootcss.com/canvas-nest.js/1.0.1/canvas-nest.min.js"></script>
