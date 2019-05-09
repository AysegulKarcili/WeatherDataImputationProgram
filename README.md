# WeatherDataImputationProgram

Completes the missing dates and missing hours in whether data belonging to Turkey cities. Uses the arithmetic average of temperature values on the one upper and one below lines.

Data for the city Elazığ is among the given files.
Here are some example data rows: (Hourly temperature data of Elazığ between 01.01.2012 00:00:00 and 02.01.2012 03:00:00)

17201|ELAZIÐ BÖLGE|2012|1|1|0|1.3
17201|ELAZIÐ BÖLGE|2012|1|1|1|0.9
17201|ELAZIÐ BÖLGE|2012|1|1|2|1.3
17201|ELAZIÐ BÖLGE|2012|1|1|3|1.1
17201|ELAZIÐ BÖLGE|2012|1|1|4|0.8
17201|ELAZIÐ BÖLGE|2012|1|1|5|1.1
17201|ELAZIÐ BÖLGE|2012|1|1|6|1.6
17201|ELAZIÐ BÖLGE|2012|1|1|7|2.0
17201|ELAZIÐ BÖLGE|2012|1|1|8|2.6
17201|ELAZIÐ BÖLGE|2012|1|1|9|3.7
17201|ELAZIÐ BÖLGE|2012|1|1|10|3.8
17201|ELAZIÐ BÖLGE|2012|1|1|11|4.2
17201|ELAZIÐ BÖLGE|2012|1|1|12|4.5
17201|ELAZIÐ BÖLGE|2012|1|1|13|4.4
17201|ELAZIÐ BÖLGE|2012|1|1|14|3.8
17201|ELAZIÐ BÖLGE|2012|1|1|15|3.8
17201|ELAZIÐ BÖLGE|2012|1|1|16|3.8
17201|ELAZIÐ BÖLGE|2012|1|1|17|3.7
17201|ELAZIÐ BÖLGE|2012|1|1|18|3.5
17201|ELAZIÐ BÖLGE|2012|1|1|19|3.3
17201|ELAZIÐ BÖLGE|2012|1|1|20|3.2
17201|ELAZIÐ BÖLGE|2012|1|1|21|3.0
17201|ELAZIÐ BÖLGE|2012|1|1|22|2.7
17201|ELAZIÐ BÖLGE|2012|1|1|23|2.2
17201|ELAZIÐ BÖLGE|2012|1|2|0|1.9
17201|ELAZIÐ BÖLGE|2012|1|2|1|1.9
17201|ELAZIÐ BÖLGE|2012|1|2|2|1.7
17201|ELAZIÐ BÖLGE|2012|1|2|3|1.8

If, for example, the third row was missing, the program would input the line with 1.0 degrees Celcius. ((0.9+1.1)/2 = 1.0)
