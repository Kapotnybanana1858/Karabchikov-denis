#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include <opencv2/core/core.hpp>
#include<iostream>
#include<stdio.h>
#include<stdlib.h>
#include <string>

using namespace cv;
using namespace std;
int main()
{
	int height = 1080;
	int width = 1920;
	Mat img(height, width, CV_8UC3);
	Point textOrg(100, img.rows / 2);
	int fontFace = FONT_HERSHEY_PLAIN;
	double fontScale = 3;
	Scalar color(9, 0, 255);
	namedWindow("ku", 0);	
	putText(img, "pupu kaka", textOrg, fontFace, fontScale, color);
	imshow("nyam nyam", img);
	waitKey(0);
	return 0;

}
