//
//  Levenshtein.m
//  Xevenshtein
//
//  Created by Antonio Feregrino Bolaños on 4/3/15.
//  Copyright (c) 2015 Messier16. All rights reserved.
//

#import "Levenshtein.h"
#import <Foundation/NSString.h>
#import <Foundation/NSObjCRuntime.h>

@interface Levenshtein ()

@end

@implementation Levenshtein

+ (int)compute:(NSString*)ss compareTo:(NSString*)tt{
    
    
    const char *s = [ss UTF8String];
    const char *t = [tt UTF8String];
    int n = [ss length];
    int m = [tt length];
    
    int d[n+1][m+1];
    
    // Step 1
    if (n == 0)
    {
        return m;
    }
    
    if (m == 0)
    {
        return n;
    }
    
    // Step 2
    for (int i = 0; i <= n; d[i][0] = i++)
    {
    }
    
    for (int j = 0; j <= m; d[0][j] = j++)
    {
    }
    
    // Step 3
    for (int i = 1; i <= n; i++)
    {
        //Step 4
        for (int j = 1; j <= m; j++)
        {
            
            // Step 5
            int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
            
            // Step 6
            d[i][j] = MIN(
                               MIN(d[i - 1][ j] + 1, d[i][ j - 1] + 1),
                               d[i - 1][ j - 1] + cost);
        }
    }
    
    return d[n][m];
}

@end
