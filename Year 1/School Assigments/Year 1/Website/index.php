<!DOCTYPE html>
<html lang="en">
    <head>

        <!-- Author: Michael Fesser
             Date: 12/17/2013
             Purpose: This is my personal website.
             Last Revision: 3/24/2014
             Dependencies: None
        -->

        <title>Michael Fesser's Homepage</title>

        <?php
        include './header.php';
        ?>

    </head>

    <body>

        <?php
        include './menu.php';
        ?>

        <div class="container topOffSet">
            <div class="row">
                <div class="box">
                    <div class="col-lg-12 text-center">
                        <div id="carousel-example-generic" class="carousel slide">
                            <!-- Indicators -->
                            <ol class="carousel-indicators hidden-xs">
                                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                            </ol>

                            <!-- Wrapper for slides -->
                            <div class="carousel-inner">
                                <div class="item active">
                                    <img class="img-responsive img-small" src="img/slide-1.jpg" alt="img/slide-1.jpg">
                                </div>
                                <div class="item">
                                    <img class="img-responsive img-small" src="img/slide-2.jpg" alt="img/slide-2.jpg">
                                </div>
                                <div class="item">
                                    <img class="img-responsive img-small" src="img/slide-3.jpg" alt="img/slide-3.jpg">
                                </div>                              
                            </div>

                            <!-- Controls -->
                            <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                                <span class="icon-prev"></span>
                            </a>
                            <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                                <span class="icon-next"></span>
                            </a>
                        </div>
                        <h1><small>Welcome to</small><br><span class="brand-name">My Homepage</span></h1>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="box">
                    <div class="col-lg-12">
                        <hr>
                        <h2 class="intro-text text-center">Why a Website?</h2>
                        <hr>                        
                    </div>
                    <p>Welcome to my website. What you see at the moment is essentially a proof of concept, or more proof that I understood the concepts being taught in school.</p>
                    <p>Anyone looking at this site will be able to tell that it is very basic. That is fine, I am not really much of a designer and this sites design criteria involved both forms and functions... little attempt at humour there.</p>
                    <p>Basically I am taking my very basic knowledge of HTML, CSS, JavaScript and JQuery and trying to make a website out of them using a pre-existing template. This is literally my first attempt at a website assuming your exclude geocities back in the day.</p>
                    <p>The site is broken up into six sections, my home page, the about page, my blog, the JavaScript page, my resume, and contacts. While home, about, blog, and contact are pretty straight forward the JavaScript page is a little less obvious.</p>
                    <p>The JavaScript page is for all my attempts (good or bad) at JavaScript. While they are very basic, they are both functional and practical. I do hope in time to make the projects on this page much more interesting and much more fun.</p>
                </div>
            </div>

            <?php
            include 'backToTop.php';
            ?>

        </div><!-- /.container -->

        <?php
        include 'footer.php';
        ?>

    </body>
</html>