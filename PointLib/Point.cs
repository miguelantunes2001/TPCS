
using System;

public struct Point{

public double X;
public double Y;

    public  Point(double x, double y){
        X=x;    
        Y=y;
    }

    public double getModule(){
        return Math.Sqrt(X*X+Y*Y);
    }
}