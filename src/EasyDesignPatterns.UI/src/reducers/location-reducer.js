import {urlsList} from '../page-urls';

const INITIAL_STATE={
    routesStack: ["Design Patterns"],
    actualRoute: "Design Patterns/",
    showReturnArrow: false
}

const calculateRoute = routesStack => routesStack.join('/');

const showReturnArrow = routesStack => routesStack.length > 1;

export const locationReducer = (state=INITIAL_STATE, action) => {
    switch(action.type){
        case("LOCATION_CHANGE"):{
            const routesStack = urlsList
              .sort((a, b) => a.length < b.length ? -1 : 1)
              .filter(x => action.route.match(x.url) && action.route.length >= x.url.length)
              .map(x => x.label);
            const showArrow =  showReturnArrow(routesStack);
            return {...state, routesStack, actualRoute: calculateRoute(routesStack), showReturnArrow: showArrow}
        }
        default: return {...state}
    }
}