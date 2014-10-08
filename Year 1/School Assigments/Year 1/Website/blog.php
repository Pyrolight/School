<!DOCTYPE html>
<html lang="en">
    <head>

        <!-- Author: Michael Fesser
             Date: 12/17/2013
             Purpose: This is my blog.
             Last Revision: 3/24/2014
             Dependencies: index.php
        -->

        <title>Blog</title>

        <?php
        include './header.php';
        ?>

    </head>
    <body>

        <?php
        include './menu.php';
        ?>

        <!-- blog -->
        <div class="container topOffSet">
            <div class="row">
                <div class="box">
                    <div class="col-lg-12">
                        <hr>
                        <h2 class="intro-text text-center">My <strong>blog</strong></h2>
                        <hr>
                    </div>

                    <div class="col-lg-12 text-center" id="b6">   
                        <h2>Php -> Database<br><small>March 24, 2014</small></h2>
                    </div>
                    <p>One major update, the form actually now connects to a server and the email works.  Some other minor stuff, nothing much of note.</p>


                    <div class="col-lg-12 text-center">
                        <ul class="pager">
                            <li class="previous"><a href="#b5">&larr; Older</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-12 text-center" id="b5">   
                        <h2>It's all over<br><small>December 17, 2013</small></h2>
                    </div>
                    <p>Well that’s it, I am done.  I NEVER want to see a line of HTML AGAIN!  Oh wait, all of second semester is PHP… crap.</p>
                    <p>Seriously though I am glad to be done with this.  I enjoyed making it but it was time consuming and it showed how much I don’t really know about JavaScript et al.</p>
                    <p>I plan to work on this slowly in time to add more functionality and finish some of the forms with the PHP side of things.  Right now I just want to relax a bit since they project took more time than if I had had to study for a test… a lot more.</p>
                    <p>Anyway I wish I could have learned a little more JQuery before trying to use it.  I would have liked to been able to write it more from scratch but oh well.</p>
                    <p>Anyway in the end it was fun, a time vampire, but fun.</p>

                    <div class="col-lg-12 text-center">
                        <ul class="pager">
                            <li class="previous"><a href="#b4">&larr; Older</a></li>
                            <li class="next"><a href="#b6">Newer &rarr;</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-12 text-center" id="b4">   
                        <h2>So close...<br><small>December 16, 2013</small></h2>
                    </div>
                    <p>Well this is it, the last official day.  Not too much to say really, I still need to add a third JQuery element and clean up the site some.  I added my resume to the site and did a few tweaks to make it a little nice.  It is nearly done.</p>
                    <div class="col-lg-12 text-center">
                        <ul class="pager">
                            <li class="previous"><a href="#b3">&larr; Older</a></li>
                            <li class="next"><a href="#b5">Newer &rarr;</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-12 text-center" id="b3">   
                        <h2>Almost Done!<br><small>December 15, 2013</small></h2>
                    </div>

                    <div class="col-sm-3 text-center">
                        <img class="img-responsive" src="img/snowing.jpg" alt="img/snowing.jpg">
                    </div>

                    <p>So close, all I need is another JQuery element that makes any sort of sense to have and to clean up some. It won't be quite as complete as I want but like the clock on the pages time is ticking. If I find I have some extra time I might put some validation on the JavaScript forms.</p>
                    <p>On another note as you can see it is slowing pretty good. Hopefully it won't mess up test for tomorrow since it will be nothing but a huge pain in the ass if they are delayed.</p>
                    <br /><br /><br /> 
                    <div class="col-lg-12 text-center">
                        <ul class="pager">
                            <li class="previous"><a href="#b2">&larr; Older</a></li>
                            <li class="next"><a href="#b4">Newer &rarr;</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-12 text-center" id="b2">   
                        <h2>Dammit some humans survived hunt, them down!<br><small>December 14, 2013</small></h2>
                    </div>

                    <p>Today I was at work so not too much time for the project. I redid the about page to combine it with the contact page since it made more sense. I also reformatted the blog to keep the images a more appropriate size.</p>
                    <p>The main coding for today was to add a second JQuery element. On the Javascript page all the labels for each field now have a description attached. I borrowed and modified my teachers JQuery example to get the general effect I wanted.</p>
                    <p>I tried hover for the labels instead of a click and it was amazingly annoying.</p>


                    <div class="col-lg-12 text-center">
                        <ul class="pager">
                            <li class="previous"><a href="#b1">&larr; Older</a></li>
                            <li class="next"><a href="#b3">Newer &rarr;</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-12 text-center" id="b1">   
                        <h2>Kill All Humans<br><small>December 13, 2013</small></h2>
                    </div>

                    <div class="col-sm-3 text-center">
                        <img class="img-responsive myImg" src="img/slide-1.jpg" alt="img/slide-1.jpg">
                    </div>

                    <p>This is my first blog and it will be on this time vampire I like to call my homepage.</p> 
                    <p>Any skilled programmer out there is likely laughing right now that something so simple as this could take any time but HTML, CSS and JavaScript are not clicking with me the way Java does.</p>
                    <p>That being said the website is coming along nicely. I am not that artistic so the form is not as nice as it could be. If I was artistic I would not be in programming... well that is not true, but I think you know what I mean.</p>
                    <p>I spent the last day and a bit working on the JavaScript section of the site. It is essentially a way for students to figure out their grades and figure out the section weighting after they receive a mark. How useful it will be I have no idea but it was about working through the logic involved and how to get it to work without the PHP side.</p>
                    <p>Finally the forms have very little validation at the moment, I might add it later, but this is segue to PHP for me anyway.</p>


                    <div class="col-lg-12 text-center">
                        <ul class="pager">
                            <li class="next"><a href="#b2">Newer &rarr;</a></li>
                        </ul>
                    </div>
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