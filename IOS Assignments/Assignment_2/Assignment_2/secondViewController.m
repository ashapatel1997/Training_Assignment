//
//  secondViewController.m
//  Assignment_2
//
//  Created by Asha  on 3/18/19.
//  Copyright © 2019 Asha . All rights reserved.
//

#import "secondViewController.h"

@interface secondViewController ()

@end

@implementation secondViewController
@synthesize radiobutton1,radiobutton2;
- (void)viewDidLoad {
    [super viewDidLoad];
    radiobutton1 = [[UIButton alloc] initWithFrame:CGRectMake(200, 300, 25,25)];
    [radiobutton1 setTag:0];
    
    [radiobutton1 setBackgroundImage:[UIImage imageNamed:@"off.gif"]  forState:UIControlStateNormal];
    
    [radiobutton1 setBackgroundImage:[UIImage imageNamed:@"on.png"] forState:UIControlStateSelected];
    [radiobutton1 addTarget:self action:@selector(radiobuttonSelected:) forControlEvents:UIControlEventTouchUpInside];
    
    radiobutton2 = [[UIButton alloc] initWithFrame:CGRectMake(15, 300, 25, 25)];
    [radiobutton2 setTag:1];
    [radiobutton2 setBackgroundImage:[UIImage imageNamed:@"off.gif"] forState:UIControlStateNormal];
    [radiobutton2 setBackgroundImage:[UIImage imageNamed:@"on.png"] forState:UIControlStateSelected];
    [radiobutton2 addTarget:self action:@selector(radiobuttonSelected:) forControlEvents:UIControlEventTouchUpInside];
    
    
    [self.view addSubview:radiobutton1];
    [self.view addSubview:radiobutton2];
    
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/




-(void)radiobuttonSelected:(id)sender{
    switch ([sender tag]) {
        case 0:
            if([radiobutton1 isSelected]==YES)
            {
                [radiobutton1 setSelected:NO];
                [radiobutton2 setSelected:YES];
            }
            else{
                [radiobutton1 setSelected:YES];
                [radiobutton2 setSelected:NO];
            }
            
            break;
        case 1:
            if([radiobutton2 isSelected]==YES)
            {
                [radiobutton2 setSelected:NO];
                [radiobutton1 setSelected:YES];
            }
            else{
                [radiobutton2 setSelected:YES];
                [radiobutton1 setSelected:NO];
            }
            
            break;
        default:
            break;
    }
    
}

@end
