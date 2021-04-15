import autosklearn,catboost,category_encoders,dtreeviz,eli5,fancyimpute,fastai, featuretools,glmnet_py,graphviz,hdbscan,imblearn,lime,janitor,matplotlib, missingno,mlxtend,numpy,pandas,pandas_profiling,pdpbox,phate,pydotplus,rfpimp, scikitplot,scipy,seaborn,shap,sklearn,statsmodels,tpot,treeinterpreter,umap,xgbfir,xgboost,yellowbrick

for lib in [
    autosklearn,
    catboost,
    category_encoders,
    dtreeviz,
    eli5,
    fancyimpute,
    fastai,
    featuretools,
    glmnet_py,
    graphviz,
    hdbscan,
    imblearn,
    lime,
    janitor,
    matplotlib,
    missingno,
    mlxtend,
    numpy,
    pandas,
    pandas_profiling,
    pdpbox,
    phate,
    pydotplus,
    rfpimp,
    scikitplot,
    scipy,
    seaborn,
    shap,
    sklearn,
    statsmodels,
    tpot,
    treeinterpreter,
    umap,
    xgbfir,
    xgboost,
    yellowbrick
]:
    try:
        print(lib.__name__, lib.__version__)
    except:
        print("Missing", lib.__name__)
