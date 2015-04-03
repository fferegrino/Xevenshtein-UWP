//
//  ViewController.m
//  Xevenshtein
//
//  Created by Antonio Feregrino Bolaños on 4/2/15.
//  Copyright (c) 2015 Messier16. All rights reserved.
//

#import "ViewController.h"
#import "Levenshtein.h"

@interface ViewController ()
@property (strong, nonatomic) IBOutlet UITextField *FirstWordInputText;
@property (strong, nonatomic) IBOutlet UITextField *SecondWordInputText;
@property (strong, nonatomic) IBOutlet UILabel *ResultLabel;

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)computeButtonTapped:(UIButton *)sender
{
    
    int result = [Levenshtein compute:_FirstWordInputText.text compareTo:_SecondWordInputText.text];
    _ResultLabel.text = [NSString stringWithFormat:@"%d",result];;
}

@end
