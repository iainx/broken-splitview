//
//  ViewController.m
//  windowtest
//
//  Created by iain on 27/09/2018.
//  Copyright © 2018 FalseVictories. All rights reserved.
//

#import "ViewController.h"
#import "PadViewController.h"

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];

    // Do any additional setup after loading the view.
}


- (void)setRepresentedObject:(id)representedObject {
    [super setRepresentedObject:representedObject];

    // Update the view, if already loaded.
}


- (IBAction)openWindow:(id)sender {
    PadViewController *padVC = [[PadViewController alloc] init];
    
    NSWindow *window = [NSWindow windowWithContentViewController:padVC];
    [window makeKeyAndOrderFront:nil];
}
@end
