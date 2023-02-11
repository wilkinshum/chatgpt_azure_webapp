import pytest
from your_webapp import YourWebApp

def test_your_webapp():
    webapp = YourWebApp()
    assert webapp.run() == 'Success'