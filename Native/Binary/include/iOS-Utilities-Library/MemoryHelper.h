//
//  MemoryHelper.h
//  iOS-Utilities-Library
//
//  Created by Leonardo Ribeiro Da Silva on 02/10/15.
//  Copyright © 2015 Leonardo Ribeiro Da Silva. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface MemoryHelper : NSObject

+ (long long) usedMemory;
+ (long long) freeMemory;
+ (long long) totalMemory;
+ (long long) bytesInKb:(long long)bytes;
+ (long long) bytesInMb:(long long)bytes;

@end
