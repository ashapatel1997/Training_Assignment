//
//  ViewController.m
//  Assignment_1
//
//  Created by Asha  on 3/17/19.
//  Copyright © 2019 Asha . All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController
@synthesize textField,labelField;
- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
}


- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}


- (IBAction)buttonField:(id)sender {
    
    NSString * userInput=textField.text;
    labelField.text=userInput;
    
    textField.clearButtonMode=UITextFieldViewModeWhileEditing;
}
@end
