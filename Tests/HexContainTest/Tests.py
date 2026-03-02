from funkcjaHex import contHex
import unittest

class MyTestCase(unittest.TestCase):
    def test_contains_True(self):
        self.assertEqual("Tak", contHex(12))
    def test_contains_False(self):
        self.assertFalse("Nie", contHex(9))
