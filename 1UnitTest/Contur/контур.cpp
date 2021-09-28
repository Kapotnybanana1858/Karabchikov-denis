#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/core/core.hpp>
#include<iostream>
#include<stdio.h>
#include<stdlib.h>
#include <string>

using namespace cv;
using namespace std;

Mat img;

int main()
{
	setlocale(LC_ALL, "Russia");
	char filename[80]; //car(2,3).jpg
	cout << "Vvedite imea faila, v kotorom xotite vnesti izmenenia, i nazhimite Enter" << endl;
	cin.getline(filename, 80);
	cout << "Открыть файл";
	cout << filename << endl;

	Mat img = imread(filename, 1);
	namedWindow("Исходное изображение", WINDOW_AUTOSIZE);
	imshow("Исходное изображение", img);

	Mat src_gray;
	Mat canny_output;

	cvtColor(img, src_gray, COLOR_RGB2GRAY);
	imwrite("cvtColor.jpg", src_gray);
	blur(src_gray, src_gray, Size(2, 2));
	imwrite("blur.jpg", src_gray);

	double otsu_thresh_val = threshold(src_gray, img, 0, 255, THRESH_BINARY | THRESH_OTSU);
	double high_thresh_val = otsu_thresh_val, lower_thresh_val = otsu_thresh_val * 0.5;

	cout << otsu_thresh_val; 
	Canny(src_gray, canny_output, lower_thresh_val, high_thresh_val, 3);

	
	namedWindow("Серое изображение", WINDOW_AUTOSIZE);
	imshow("Серое изображение", canny_output);
	imwrite("canny_output.jpg", canny_output);

	waitKey(0);
	return 0;
}