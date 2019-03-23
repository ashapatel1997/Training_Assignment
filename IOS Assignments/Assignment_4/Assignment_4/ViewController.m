//
//  ViewController.m
//  Assignment_4
//
//  Created by Asha  on 3/19/19.
//  Copyright © 2019 Asha . All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()
{
    int op;
    double displayNumber;
    double resultValue;
    BOOL isDecimal;
}
@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    isDecimal=false;
    resultValue=0;
    
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(void)digit:(int)number{
    if(!isDecimal){
        displayNumber *= 10;
        displayNumber += number;
        result.text = [NSString stringWithFormat:@"%.0f",displayNumber];
    }
    else{
        result.text = [result.text stringByAppendingString:[NSString stringWithFormat:@"%d", number]];
    }
    displayNumber = [result.text floatValue];
}

-(void)operation:(int)number{
    
    isDecimal = false;
    
    if(resultValue == 0){
        resultValue = displayNumber;
    }
    
    else{
        result.text = [NSString stringWithFormat:@"%.2f",resultValue];
        switch (op) {
            case 1:
                resultValue += displayNumber;
                break;
            case 2:
                resultValue -= displayNumber;
                break;
            case 3:
                resultValue *= displayNumber;
                break;
            case 4:
                resultValue /= displayNumber;
                break;
                
            default:
                break;
        }
    }
    op = number;
    if (op==1) {
        result.text = [NSString stringWithFormat:@"+"];
    }
    else if(op==2) {
        result.text = [NSString stringWithFormat:@"-"];
        
    }
    else if(op==3) {
        result.text = [NSString stringWithFormat:@"*"];
        
    }
    else if(op==4) {
        result.text = [NSString stringWithFormat:@"/"];
    }
    
    displayNumber = 0;
    
}




- (IBAction)divide:(id)sender
{
    if(resultValue != 0){
        [self operation:op];
        result.text = [NSString stringWithFormat:@"%.2f",resultValue];
        displayNumber = [result.text floatValue];
        resultValue = 0;
    }
    [self operation:4];
}

- (IBAction)multiply:(id)sender
{
    if(resultValue != 0){
        [self operation:op];
        result.text = [NSString stringWithFormat:@"%.2f",resultValue];
        displayNumber = [result.text floatValue];
        resultValue = 0;
    }
    [self operation:3];
}

- (IBAction)minus:(id)sender
{
    if(resultValue != 0){
        [self operation:op];
        result.text = [NSString stringWithFormat:@"%.2f",resultValue];
        displayNumber = [result.text floatValue];
        resultValue = 0;
    }
    [self operation:2];
}

- (IBAction)plus:(id)sender {
    if(resultValue != 0){
        [self operation:op];
        result.text = [NSString stringWithFormat:@"%.2f",resultValue];
        displayNumber = [result.text floatValue];
        resultValue = 0;
    }
    [self operation:1];
}

-(IBAction)dot:(id)sender {
    isDecimal = true;
    NSRange range = [result.text rangeOfString:@"."];
    if (range.location ==NSNotFound){
        result.text = [result.text stringByAppendingString:@"."];
    }
}

- (IBAction)equals:(id)sender {
    
    [self operation:op];
    result.text = [NSString stringWithFormat:@"%.2f",resultValue];
    displayNumber = [result.text floatValue];
    resultValue = 0;
}

- (IBAction)clear:(id)sender {
    op = 0;
    resultValue = 0;
    displayNumber = 0;
    isDecimal = false;
    result.text = [NSString stringWithFormat:@"%i",0];
}

- (IBAction)seven:(id)sender {
    [self digit:7];
}

- (IBAction)eight:(id)sender {
    [self digit:8];
}

- (IBAction)nine:(id)sender {
    [self digit:9];
}


- (IBAction)four:(id)sender {
    [self digit:4];
}

- (IBAction)five:(id)sender {
    [self digit:5];
}

- (IBAction)six:(id)sender {
    [self digit:6];
}

- (IBAction)one:(id)sender {
    [self digit:1];
}

- (IBAction)two:(id)sender {
    [self digit:2];
}

- (IBAction)three:(id)sender {
    [self digit:3];
}


- (IBAction)zero:(id)sender {
    [self digit:0];
}


@end
