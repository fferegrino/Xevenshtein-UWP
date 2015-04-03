//
//  Levenshtein.h
//  Xevenshtein
//
//  Created by Antonio Feregrino Bolaños on 4/3/15.
//  Copyright (c) 2015 Messier16. All rights reserved.
//

#import <Foundation/NSObject.h>

#ifndef Xevenshtein_Levenshtein_h
#define Xevenshtein_Levenshtein_h


@interface Levenshtein : NSObject

+ (int)compute:(NSString*)ss compareTo:(NSString*)tt;

@end

#endif
