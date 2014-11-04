<?xml version="1.0" encoding="UTF-8"?>

<!--
    Author: Michael Fesser
    Date: Nov 3, 2014
    Purpose: This is the stylesheet for forecast.xml.  It displays a very basic weather report.  
    It shows the date, an image representing the weather conditions, the high and low,
    the description of the weather and the average.  As many types of xsl used as possible
    with the exception of the images.
    Last Revision: Nov 3, 2014
    Dependencies: forecast.sml
-->

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>
    <xsl:template match="/">
        <html>
            <head>
                <title>Forecast Style Sheet</title>
            </head>
            <body>
                <!-- Get the values from the XML file for the location and display them -->
                <h1>
                    <xsl:text>Forecast for </xsl:text>
                    <xsl:value-of select="forecast/location/city"/>
                    <xsl:text>, </xsl:text>
                    <xsl:value-of select="forecast/location/province"/>
                    <xsl:text>, </xsl:text>
                    <xsl:value-of select="forecast/location/country"/>                      
                </h1>     
                <h2>
                    <span style="font-style:italic">
                        <xsl:text>Degrees in </xsl:text>
                    </span>
                    <xsl:value-of select="forecast/location/degrees"/>
                </h2>
                <h2>
                    <xsl:text>Five Day Forecast</xsl:text>
                </h2>
                <!-- End display -->
                <table style="border: 1px solid black;">
                    <tr>
                        <!-- Get and display each day's properties from the XML file -->
                        <xsl:for-each select="forecast/daily/day">
                            <!-- Some CSS styes, the width is set smaller then the image width to force element to the width of the image -->
                            <td style="border: 1px solid black;padding:4px;width:100px">
                                <xsl:value-of select="date"/>
                                <br />  
                                <!-- Choose the picture -->                           
                                <xsl:choose>
                                    <xsl:when test="condition = 'lightning'">
                                        <img src="../img/lightning.jpg" alt=""/> 
                                    </xsl:when>
                                    <xsl:when test="condition = 'overcast'">
                                        <img src="../img/overcast.jpg" alt=""/> 
                                    </xsl:when>
                                    <xsl:when test="condition = 'rain'">
                                        <img src="../img/rain.jpg" alt="" /> 
                                    </xsl:when>
                                    <xsl:when test="condition = 'snow'">
                                        <img src="../img/snow.jpg" alt=""/> 
                                    </xsl:when>
                                    <xsl:when test="condition = 'sun-cloud'">
                                        <img src="../img/sun-cloud.jpg" alt=""/> 
                                    </xsl:when>
                                    <xsl:when test="condition = 'sun'">
                                        <img src="../img/sun.jpg" alt=""/> 
                                    </xsl:when>
                                </xsl:choose>
                                <br />
                                <!-- Display the high and low -->
                                <xsl:text>High: </xsl:text>
                                <xsl:value-of select="high"/>&#176;
                                <br />
                                <xsl:text>Low: </xsl:text>
                                <xsl:value-of select="low"/>&#176;
                                <br />
                            </td> 
                        </xsl:for-each>
                    </tr>
                    <tr>
                        <!-- Get and display the descriptions for each day -->
                        <xsl:for-each select="forecast/daily/day">
                            <td style="border: 1px solid black;padding:4px;vertical-align:top">
                                <xsl:value-of select="description"/>
                            </td>
                        </xsl:for-each>
                    </tr>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
