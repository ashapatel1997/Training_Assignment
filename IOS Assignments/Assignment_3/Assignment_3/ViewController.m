//
//  ViewController.m
//  Assignment_3
//
//  Created by Asha  on 3/19/19.
//  Copyright © 2019 Asha . All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()<UICollectionViewDelegate,UICollectionViewDataSource>
@property NSArray * images;
@property NSArray * labels;
@end

@implementation ViewController
@synthesize collection_view;
- (void)viewDidLoad {
    [super viewDidLoad];
    _images=[[NSArray alloc]initWithObjects:@"backwaters.jpg",@"jaisalmer.jpg",@"redfort.jpg",@"lakepalace.jpg",@"qutubMinar.jpg",@"amberFort.jpg",@"goldenTemple.jpg",@"theRidge.jpg",@"valleyOfFlowers.jpg", nil];
    _labels=[[NSArray alloc]initWithObjects:@"Backwaters",@"Jaisalmer Fort",@"Red Fort",@"Lake Palace",@"Qutub Minar",@"Amber Fort",@"Golden Temple",@"The Ridge",@"Valley of Flowers", nil];
}



- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
}

- (NSInteger)collectionView:(UICollectionView *)collectionView numberOfItemsInSection:(NSInteger)section
{
    return _images.count;
}


- (__kindof UICollectionViewCell *)collectionView:(UICollectionView *)collectionView cellForItemAtIndexPath:(NSIndexPath *)indexPath
{
    UICollectionViewCell * cell=[collectionView dequeueReusableCellWithReuseIdentifier:@"cell" forIndexPath:indexPath];
    
    UIImageView * img=(UIImageView *)[cell viewWithTag:1];
    UILabel *lbl=(UILabel *)[cell viewWithTag:2];
    
    img.image=[UIImage imageNamed:[_images objectAtIndex:indexPath.row]];
    lbl.text=[_labels objectAtIndex:indexPath.row];
    
    return cell;
}

- (NSInteger)numberOfSectionsInCollectionView:(UICollectionView *)collectionView
{
    return 1;
}
@end
