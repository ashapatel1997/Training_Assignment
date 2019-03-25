//
//  ViewController.m
//  Assignment_5
//
//  Created by Asha  on 3/25/19.
//  Copyright © 2019 Asha . All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()
{
    NSArray *dataArray;
 
}
@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    [self fetchJson];
    self.navigationItem.title=@"Countries";
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    return dataArray.count;
}


- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"cell" forIndexPath:indexPath];
    
  id keyValuePair =dataArray[indexPath.row];
    
    
    NSData *data = [[NSData alloc]initWithBase64EncodedString:keyValuePair[@"media"] options:NSDataBase64DecodingIgnoreUnknownCharacters];
    
    
    UIImageView *image=(UIImageView *)[cell viewWithTag:1];
    UILabel *name=(UILabel *)[cell viewWithTag:2];
     UILabel *pCode=(UILabel *)[cell viewWithTag:3];
     UILabel *cCode=(UILabel *)[cell viewWithTag:4];
    
    
    image.image=[UIImage imageWithData:data];
    
    name.text=[NSString stringWithFormat:@"%@ ",keyValuePair[@"name"]];
    
    pCode.text=[NSString stringWithFormat:@"Phone Code: %@ ",keyValuePair[@"phoneCode"]];
    
     cCode.text=[NSString stringWithFormat:@"%@ ",keyValuePair[@"countryCode"]];
    
    cell.backgroundColor = UIColor.whiteColor;
    cell.layer.borderColor=UIColor.blackColor.CGColor;
    cell.layer.borderWidth = 1;
    cell.layer.cornerRadius = 8;
    cell.clipsToBounds = true;
    return cell;
}



-(void) fetchJson
{NSString *fileName = [[NSBundle mainBundle] pathForResource:@"countrylist" ofType:@"json"];
    if (fileName)
    {
       
        NSLog(@"file found!");
        NSData *cData = [[NSData alloc] initWithContentsOfFile:fileName];
        
        NSError *error;
        dataArray=(NSArray *)[NSJSONSerialization JSONObjectWithData:cData options:0 error:&error];
        
        
        if (error)
        {
            NSLog(@"Something went wrong! %@", error.localizedDescription);
        }
        else
        {
            
            NSLog(@"Totle %lu entries",dataArray.count);
            
        }
    }
    else
    {
        NSLog(@"Couldn't find file!");
    }
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}


@end
