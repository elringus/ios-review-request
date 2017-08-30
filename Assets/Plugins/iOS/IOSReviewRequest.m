#import <StoreKit/StoreKit.h>

void RequestReviewInternal()
{
    #if __IPHONE_OS_VERSION_MAX_ALLOWED >= 103000
    [SKStoreReviewController requestReview];
    #endif
}
